
/* 2022.04.05 최낙현
 * 목적: .NET의 SerialPort 객체를 이용하여 아두이노와 시리얼 통신하는 방식을 테스트한다.
 * 기능: UGUI 버튼을 누르면 지정된 LED를 켜고 끌 수 있게한다. 
 */

using UnityEngine;
using System.IO.Ports;

public class SerialTest : MonoBehaviour
{
    SerialPort sp = new SerialPort("COM6",9600); // BandRate를 반드시 아두이노와 맞추어야함. 
    
    void Awake()
    {
        sp.Open(); // 시리얼 포트를 열어줌 
    }
    

    /// <summary>
    /// LED 키기 버튼 누르기. 
    /// </summary>
    public void Onclick_On()
    {
        sp.Write("o");
    }

    public void OnClick_Off()
    {
        sp.Write("c"); // 아두이노에 저장되어 있는 string을 보냅니다.
    }

    void OnApplicationQuit() 
    { 
        sp.Close(); 
    } 
    
}
