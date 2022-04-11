int trigPin = 6;
int echoPin = 7;
long result_value;
void setup() {
  Serial.begin(9600);
  pinMode(8,OUTPUT);// 전원이 들어옴 유무를 보여주는 led 
  pinMode(echoPin, INPUT);
  pinMode(trigPin, OUTPUT);
  digitalWrite(8,HIGH); // 전원이 들어와있으면, 상시전원 공급 
}

void loop() {
   digitalWrite(trigPin,HIGH); // trig에서 초음파 발생
   delayMicroseconds(10);
   digitalWrite(trigPin,LOW);
   result_value = pulseIn(echoPin, HIGH);
   Serial.println(result_value);
   Serial.flush();
}
