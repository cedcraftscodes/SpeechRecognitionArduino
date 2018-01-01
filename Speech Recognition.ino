#define BaudRate 9600
#define LED1    13
#define LED2    12
#define LED3    11
#define LED4    10

char incomingOption;

void setup()
{
  pinMode(LED1, OUTPUT);
  pinMode(LED2, OUTPUT);
  pinMode(LED3, OUTPUT);
  pinMode(LED4, OUTPUT);
  Serial.begin(BaudRate);
}
void loop()
{
     incomingOption = Serial.read();
     switch(incomingOption){
        case '1':
          digitalWrite(LED1, HIGH);
          break;
        case '2':
          digitalWrite(LED1, LOW);
          break;

        case '3':
          digitalWrite(LED2, HIGH);
          break;
          
        case '4':
          digitalWrite(LED2, LOW);
          break;
          
        case '5':
          digitalWrite(LED3, HIGH);
          break;
          
        case '6':
          digitalWrite(LED3, LOW);
          break;

        case '7':
          digitalWrite(LED4, HIGH);
          break;
        case '8':
          digitalWrite(LED4, LOW);
          break;


         case '9':
          digitalWrite(LED1, HIGH);
          digitalWrite(LED2, HIGH);
          digitalWrite(LED3, HIGH);
          digitalWrite(LED4, HIGH);
          break;
          
        case '0':
          digitalWrite(LED1, LOW);
          digitalWrite(LED2, LOW);
          digitalWrite(LED3, LOW);
          digitalWrite(LED4, LOW);
          break;

          

          
     }
}

