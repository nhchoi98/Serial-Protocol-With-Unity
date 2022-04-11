## 2 번째 시리얼 통신 학습
- 첫 번째 과정과 통신방향이 거꾸로라고 생각하면 됨.
- 이번엔 아두이노에서 유니티로 Serial data를 보냄. 
# A. 시스템 설계 요구사항: 
1. 전원이 인가되면 LED가 점등되어야함
2. 초음파 센서를 통해 값을 얻어, 탐지된 물체의 거리가 기준 거리보다 가까우면 이미지를 빨간색으로 표시하고, 아니면 초록색으로 표시한다. 

# B. 회로구성도 
![111](https://user-images.githubusercontent.com/68228162/162676840-c942e283-bf48-4dcf-88fb-3c5d4672c97d.jpg)



# C. 학습한 내용
## 1. 들어오는 내용에 대한 처리 방법
- 그냥 시리얼 Println으로 값들을 뽑아내려고 하니, 값이 다 끊겨서 들어오더라. 
- 그래서 데이터들을 라인으로 구별! 
- C# .NET에서는 Evene delegate로 값들이 들어오면 자동 호출되는 함수가 있는데, 이게 유니티에서는 구현이 안됨!
→ 그래서 Thread를 통해서 해결함. 


# D. 궁금증 
- 1. Thread로 읽어와도, UI요소를 바꾸려면 결국 Single Thread로 처리하는 꼴이 되어버리는데..이걸 해결할 수 있는 방법이 여러개가 있는듯 함 
(
https://timeboxstory.tistory.com/24
http://lab.gamecodi.com/board/zboard.php?id=GAMECODILAB_QnA_etc&page=1&sn1=&divpage=1&sn=off&ss=on&sc=on&select_arrange=hit&desc=desc&no=2476
https://sunpil.tistory.com/485
)

효율성 체크를 진행해보고 싶은데, 아직 그럴 단계는 아니라 어떻게 할 수 있는지만 아는것으로. Issue에 넘겨두고 꾸준히 찾아보면 좋을듯!

- 2. 지금은 값을 하나만 읽어와서 괜찮지만, 여러개를 읽어 오는경우 라인으로 구분하는 방법은 쓸 수 없을듯 한데, 어떻게 구별할까? 
