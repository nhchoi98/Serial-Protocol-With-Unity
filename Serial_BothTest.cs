using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Threading;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

/// <summary>
/// 2022.04.08 최낙현 
/// 아두이노와 시리얼 통신을 통해 양방향 통신을 위해서 어떻게 코드를 짜야할지 학습하기 위해 만든 TestProject
/// 1. 초음파 센서에서 값을 가져옴
/// 2. 그 값이 특정 값 보다 크면, UI의 색상을 바꿔주고, 거꾸로 led의 불빛을 켜줌. 
/// </summary>
public class Serial_BothTest : MonoBehaviour
{
    [SerializeField] private Image image;
    
    [Header("Serial_Info")]
    private const string PORTNUM = "COM7"; // 시리얼 포트 번호 
    private const int bandRate = 9600; // 통신 비트레이트 
    private SerialPort sp;

    [Header("Thread")]
    private bool is_already_alerted;
    private Thread portReadingThread;
    private Queue<UnityAction> actionBuffer = new Queue<UnityAction>();
    
    private const float speedOfSound = 340f;
    private Color red = new Color(255f, 0f, 0f);
    private Color green = new Color(0f, 255f, 0f);
    
    void Awake()
    {
        sp = new SerialPort(PORTNUM,bandRate); // BandRate를 반드시 아두이노와 맞추어야함. 
        sp.ReadTimeout = 5000;
        sp.NewLine = "\n";
        sp.Open();
        portReadingThread = new Thread(serialPort_DataReceived);
        portReadingThread.Start();

    }

    private void FixedUpdate()
    {
        if(actionBuffer.Count>0)
            actionBuffer.Dequeue().Invoke();
    }

    private void Set_Img_Color(ref string data)
    {
        float data_num = float.Parse(data); // string을 float로 parsing
        if (data_num / speedOfSound < 10)
            image.color = red;
        else
            image.color = green;
        
    }
    
    private void OnDestroy()
    {
        Thread.ResetAbort();
        sp.Close();
    }

    private void serialPort_DataReceived()
    {
        string ReceiveData;
        if (sp == null)
            return;
        
        while (sp.IsOpen)
        {
            ReceiveData = sp.ReadLine();
                if (ReceiveData != null || ReceiveData != "")
                    actionBuffer.Enqueue(delegate { Set_Img_Color(ref ReceiveData); });
                
            Thread.Sleep(1);
            
        }
    }
}
