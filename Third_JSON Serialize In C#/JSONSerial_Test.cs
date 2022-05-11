using UnityEngine;

public class JSONSerial_Test : MonoBehaviour
{
    public Transform tracking_pos;
    public WrapPositionVO m_PosVO;


    private Vector3 m_Pos;
    private Quaternion quaternion;
    // Start is called before the first frame update
    void Start()
    {
        m_PosVO = new WrapPositionVO();
    }

    private void FixedUpdate()
    {
        Set_mPosVO();
    }

    private void Set_mPosVO()
    {
        m_Pos = tracking_pos.position;
        quaternion = tracking_pos.rotation;
        
        m_PosVO.m_xPos = m_Pos.x;
        m_PosVO.m_yPos = m_Pos.y;
        m_PosVO.m_zPos = m_Pos.z;

        m_PosVO.m_xRot = quaternion.x;
        m_PosVO.m_yRot = quaternion.y;
        m_PosVO.m_zRot = quaternion.z;
        m_PosVO.m_wRot = quaternion.w;
        
    }
}
