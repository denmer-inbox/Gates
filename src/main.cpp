
#include "def.h"

extern bool gUOpen, gUClose, gDOpen, gDClose, loop1, loop2, loop3;

LCD_1602_RUS lcd(0x27, 16, 2);

Gates classGates;

void setup()
{
  settingPins(); // выставляем состояния пинов IO

  classGates.getPosGates(); //получаем значения пинов в переменные boolean

  Serial.begin(9600);
  lcd.begin();

  lcd.setBacklight(1); //  Включаем подсветку LCD дисплея
  lcd.setCursor(0, 0); //  Устанавливаем курсор в позицию (0 столбец, 0 строка)
  lcd.print("KOHTPOЛЛЕP BOPOT");

  delay(4000);

  lcdMain();
}

void loop()
{

  if (classGates.posGates.loop1 == LOW)
  {
    Serial.println("LOOP1 FIXED!!!");
  }
  if (classGates.posGates.loop2 == LOW)
  {
    Serial.println("LOOP2 FIXED!!!");
  }
  if (classGates.posGates.loop3 == LOW)
  {
    Serial.println("LOOP3 FIXED!!!");
  }
}

void lcdMain()
{
  lcd.clear();
  lcd.setCursor(0, 0);
  lcd.print("текущее время");
}