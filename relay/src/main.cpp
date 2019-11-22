
#include "my_set.h"

void setup()
{
  initial();
  setPins();

  lcd.init();
  lcd.backlight();
  lcd.setCursor(0, 0);
  lcd.print("Контроллер CLGv1");

  delay(300);
  Serial.begin(9600);
  rtc.begin();
 // rtc.settime(0, 51, 21, 27, 10, 15, 2); // 0  сек, 51 мин, 21 час, 27, октября, 2015 года, вторник
}
void loop()
{
  FmainLCD();
  Fkeys();
}