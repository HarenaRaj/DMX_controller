#include <DMXSerial.h>

void setup() {
  DMXSerial.init(DMXController);
  Serial.begin(9600);
}

void loop() {
  while (Serial.available() > 0) {
    String inputString = Serial.readStringUntil('\n'); // Reception des données en Chaine de caractère Hexadécimal
    
    for (int i = 0; i < inputString.length(); i += 2) {
      String channelStringHexData = inputString.substring(i, i + 2);
      DMXSerial.write((i/2)+1, StrToHex(channelStringHexData));
    }
  }
  delayMicroseconds(2000);
}

// Conversion de la Chaine de caractère Hexadécimal en Entier (int)
int StrToHex(String hexString)
{
  return (int) strtol(hexString.c_str(), NULL, 16);
}
