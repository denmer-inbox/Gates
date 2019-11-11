#include "DS1302.h"
#include "def.h"

extern bool gUOpen, gUClose, gDOpen, gDClose, loop1, loop2, loop3;

LCD_1602_RUS lcd(0x27, 16, 2);

DS1302 rtc(A3, A4, A5);

Gates classGates;

void setup()
{

  rtc.halt(false);
  rtc.writeProtect(false);
  rtc.setDOW(FRIDAY);
  rtc.setDate(10, 11, 2019);
  rtc.setTime(22, 0, 0);

  settingPins(); // выставляем состояния пинов IO

  classGates.getPosGates(); //получаем значения пинов в переменные boolean

  Serial.begin(9600);
  lcd.begin();

  lcd.setBacklight(1); //  Включаем подсветку LCD дисплея
  lcd.setCursor(0, 0); //  Устанавливаем курсор в позицию (0 столбец, 0 строка)
  lcd.print("KOHTPOЛЛЕP BOPOT");

  delay(4000);

  lcdMain();

  classGates.mainLogic();
}

void loop()
{
  Serial.print(rtc.getDateStr());
  Serial.println(rtc.getTimeStr());
  delay(1000);
}

void lcdMain()
{
  lcd.clear();
  lcd.setCursor(0, 0);
  lcd.print("текущее время");
}