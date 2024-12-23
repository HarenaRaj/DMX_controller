#include <DMXSerial.h>

void setup() {
  DMXSerial.init(DMXController); // Initialisation DMX
  Serial.begin(250000);          // Initialisation de la communication série
}

void loop() {
  static uint8_t channel = 1;  // Canaux DMX (commence à 1)
  static uint8_t tempValue = 0;
  static bool highNibble = true;

  while (Serial.available() > 0) {
    char incomingByte = Serial.read();

    if (incomingByte == '\n') {
      // Réinitialise les canaux après chaque ligne
      channel = 1;
      highNibble = true;
    } else if (isHexadecimalDigit(incomingByte)) {
      // Convertit le caractère hexadécimal en une valeur décimale
      uint8_t value = hexToDecimal(incomingByte);

      if (highNibble) {
        tempValue = value << 4; // Stocke le nibble haut
        highNibble = false;
      } else {
        tempValue |= value;     // Combine avec le nibble bas
        DMXSerial.write(channel++, tempValue); // Écrit sur le canal DMX
        if (channel > 512) channel = 1;        // Réinitialise si on dépasse 512 canaux
        highNibble = true;
      }
    }
  }
}

// Fonction inline pour convertir un caractère hexadécimal en décimal
inline uint8_t hexToDecimal(char hex) {
  return (hex >= '0' && hex <= '9') ? hex - '0' :
         (hex >= 'A' && hex <= 'F') ? hex - 'A' + 10 :
         (hex >= 'a' && hex <= 'f') ? hex - 'a' + 10 : 0;
}
