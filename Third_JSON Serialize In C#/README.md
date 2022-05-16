# 목표
 1. JSON 객체를 Serialize하여 string으로 변환, 이를 아두이노로 보낸다.
 2. 이를 아두이노에서 처리하여 서보 모터를 제어하고, 간단한 2차원 회전에 대해서 가상 물체와 움직임을 연동하는것을 목표로 한다. 
 3. Dynamixel Shield를 이용하여 서보모터를 제어하는 방법에 대해 학습한다. 

# 1. Software Serial
 - 아두이노에서 Serial 포트가 모자랄 때 쓰라고 만들어 놓은 라이브러리
 - 2번, 3번 입출력 핀을 이용해 추가적인 Serial 포트를 만들 수 있다. 

## Reference 
1. https://m.blog.naver.com/PostView.naver?isHttpsRedirect=true&blogId=leegh1587&logNo=220613423857
2. https://ai0.kr/3 (서보 제어 참조 1)
3. https://blog.naver.com/siook12/222596501534 (서보 제어 참조 2, 다이나믹셀)
4. https://github.com/ROBOTIS-GIT/DynamixelShield (서보 제어 참조 3, 다이나믹셀)
5. https://emanual.robotis.com/docs/kr/parts/interface/dynamixel_shield/ (메뉴얼)
6. https://emanual.robotis.com/docs/en/software/arduino_ide/#opencm904-examples (다이나믹셀 라이브러리 메뉴얼)
7. https://blog.naver.com/darknisia/220808977305 (Software Serial 기본 동작 방법) 
