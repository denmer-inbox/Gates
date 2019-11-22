#include <Arduino.h>
#include <HardwareSerial.h>
#include "iarduino_RTC.h"
#include "LCD_1602_RUS.h"

boolean mainLCD = true, main1L = false, flcd = true;
byte line=2;
String lineL[8]={"Время работы","светофоров","Режим работы","ворот","Установка времени","переключения","Настройка часов",""};

        LCD_1602_RUS lcd(0x27, 16, 2);

    iarduino_RTC rtc(RTC_DS1302, A0, A1, A2);

    void setPins()
    {
        pinMode(A3, INPUT_PULLUP);
        pinMode(A6, INPUT_PULLUP);
        pinMode(A7, INPUT_PULLUP);

        pinMode(2, OUTPUT);
        pinMode(3, OUTPUT);
        pinMode(4, OUTPUT);
        pinMode(5, OUTPUT);

        digitalWrite(2, HIGH);
        digitalWrite(3, HIGH);
        digitalWrite(4, HIGH);
        digitalWrite(5, HIGH);
    }

    void Fkeys()
    {

        if (!digitalRead(A3) && flcd)
        {
            mainLCD = false;
            main1L = true;
            lcd.clear();
            delay(5);
        }

        if (!digitalRead(A6))
        {
        }

        if (!digitalRead(A7))
        {
        }
    }

    void initial()
    {
    }

    void FmainLCD()
    {
        if (mainLCD == true)
        {

            if (millis() % 1000 == 0)
            { // если прошла 1 секунда
                lcd.setCursor(0, 1);
                lcd.print(rtc.gettime("H:i:s, D"));
                delay(1); // приостанавливаем на 1 мс, чтоб не выводить время несколько раз за 1мс
            }
        }

        if (main1L && flcd)
        {
            flcd = false;
            lcd.setCursor(0, 0);
            lcd.print(lineL[line]);
            lcd.setCursor(0, 1);
            lcd.print(lineL[line+1]);
        }
    }