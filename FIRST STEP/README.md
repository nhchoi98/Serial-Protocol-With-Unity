# 첫 번째 단계.. 아두이노를 이용해 LED 키고 끄기 
- 하위 디렉토리 FIRST_STEP 에 들어가면 구체적인 코드 확인 가능 
- Requirement: ui의 버튼을 누르면 led를 키고 끌 수 있게 만듬.
- 반드시 BandRate를 아두이노와 맞추어야함.
- 이 단계는 컴퓨터에서 아두이노로 시리얼 통신 방법으로써 값을 보내는것만 실습함.
- 따라서, 뒤따라오는 학습에서는 거꾸로 아두이노에서 컴퓨터로 값을 보내게 해야함. 
- 이 예제를 진행하며 학습한 사항은 아래와 같음.

# Pre. System.IO.Ports
![image](https://user-images.githubusercontent.com/68228162/161706421-7178c8f5-3bb4-4e77-aff7-7353cdb8a132.png)

## 1. Serial Port Class 
![image](https://user-images.githubusercontent.com/68228162/161706641-c995084b-7ffb-4ca5-8302-e7a5e2f280dc.png)
![image](https://user-images.githubusercontent.com/68228162/161706686-cd60d74d-c12c-4e5e-848b-bc9164572a93.png)
![image](https://user-images.githubusercontent.com/68228162/161706704-6e71c4de-341d-4f4d-ab6f-d2c0240be1c4.png)
![image](https://user-images.githubusercontent.com/68228162/161706739-86afc160-89f1-43b7-87f1-7b66101feceb.png)
![image](https://user-images.githubusercontent.com/68228162/161706755-5debcc0a-dc33-4f86-9c9e-ef0679217718.png)
![image](https://user-images.githubusercontent.com/68228162/161706769-83c59e3f-a2ee-45dc-a51e-caac11a053e3.png)


# Question
1. 한 번에 얼마나 많은 양의 Buffer를 처리할 수 있을지? 
2. 한 아두이노에 (UNO 기준) 얼마나 많은 센서를 실시간 처리할 수 있을까?  


※ 참고 사이트 
1. https://docs.microsoft.com/ko-kr/dotnet/api/system.io.ports.serialport?view=dotnet-plat-ext-6.0
2. https://create.arduino.cc/projecthub/raisingawesome/unity-game-engine-and-arduino-serial-communication-12fdd5
3. https://www.arduino.cc/reference/en/ (아두이노 관련 함수 정리 사이트) 
