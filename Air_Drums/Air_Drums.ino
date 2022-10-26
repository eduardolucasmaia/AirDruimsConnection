#include <AcceleroMMA7361.h>


int calibrar;

//Baqueta esquerda
AcceleroMMA7361 accelero1;
int x1;
int y1;
int z1;
int tocar1 = 0;
int chimbalAberto = 0;

//Baqueta direita
AcceleroMMA7361 accelero2;
int x2;
int y2;
int z2;
int tocar2 = 0;

//Pedal esquerdo
const int pedal1  = 22;
int estadoPedal1;
int podePedal1 = 0;


//Pedal direito
const int pedal2  = 23;
int estadoPedal2;
int podePedal2 = 0;

void setup()
{
  //Baqueta esquerda
  accelero1.begin(13, 12, 11, 10, A0, A1, A2); //  (SL,ST,0G,GS,X,Y,Z)
  accelero1.setARefVoltage(5);
  accelero1.setSensitivity(HIGH); 
  accelero1.calibrate();
  
  //Baqueta direita
  accelero2.begin(7, 6, 5, 4, A3, A4, A5); //  (SL,ST,0G,GS,X,Y,Z)
  accelero2.setARefVoltage(5);
  accelero2.setSensitivity(HIGH); 
  accelero2.calibrate();
  
  //Pedal Esquerdo
  pinMode(pedal1,INPUT);
  digitalWrite(pedal1,HIGH);
  
  //Pedal direito
  pinMode(pedal2,INPUT);
  digitalWrite(pedal2,HIGH);
  
  Serial.begin(9600);
}

void loop(){
  
  int estadoPedal1 = digitalRead(pedal1);
  int estadoPedal2 = digitalRead(pedal2);
  
  x1 = accelero1.getXAccel();
  y1 = accelero1.getYAccel();
  z1 = accelero1.getZAccel() * -1;
  
  x2 = accelero2.getXAccel();
  y2 = accelero2.getYAccel();
  z2 = accelero2.getZAccel() * -1;
  
  calibrar = Serial.read();

  if (calibrar == '5') //Para Calibrar as baquetas
    {   
     accelero1.calibrate();
     accelero2.calibrate();
     Serial.write('6');
     delay(75);
    }  


    //Tocar som baqueta Esquerda
  if(tocar2 == 0 && z2 >= 60){
    tocar2 = 1;
  }
  if(tocar2 == 1 && z2 <= -60){
    if(chimbalAberto == 1){
      Serial.write('1');
    }
    if(chimbalAberto == 0){
      Serial.write('3');
    }
    delay(75);
    tocar2 = 0;
  }

  //Tocar som baqueta direita
  if(tocar1 == 0 && z1 >= 60){
    tocar1 = 1;
  }
  if(tocar1 == 1 && z1 <= -60){
    Serial.write('2');
    delay(75);
    tocar1 = 0;
  }

  
        //Pedal Esquerdo
  if(estadoPedal2 == HIGH){
    chimbalAberto = 1;
  }
  if (estadoPedal2 == LOW){
    chimbalAberto = 0;
  }
  
    //Pedal Direto
  if(podePedal1 == 1 && estadoPedal1 == HIGH){
    Serial.write('4');
    delay(75);
    podePedal1 = 0;
  }
  if (podePedal1 == 0 && estadoPedal1 == LOW){
     podePedal1 = 1;
  }
  

  
    delay(10);
}
