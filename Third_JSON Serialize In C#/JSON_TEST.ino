String InputString;
bool SetValidData = 0; 
bool StringComplete = 0;


void serialEvent()
{
    char inChar;
    SetValidData = 1;
   // Serial.write("Data Received\n");
    while(Serial.available()){
      inChar = Serial.read();
      if(SetValidData)
      {
            if (inChar == 0x0a) {
               StringComplete = 1;
               SetValidData = 0;
               return;
            }

            InputString += inChar;
      }
     
    }
}


void setup() {
  Serial.begin(9600);

}

void loop() {
  // put your main code here, to run repeatedly:
  if(StringComplete && InputString.length()){
   Serial.println(InputString);
   StringComplete = 0;
   InputString = "";
  }
}
