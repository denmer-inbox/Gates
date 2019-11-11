#include <Arduino.h>
#include "LCD_1602_RUS.h"
#include <HardwareSerial.h>

#define trafLightInDOWNtime 20000 // время в мсек. задержки работы светофора проезда в низ
#define trafLightInUPtime 20000   // время в мсек.задержки работы светофора проезда вверх

#define getLOOP1 digitalRead(0) // получить сост. датчика петли 1
#define getLOOP2 digitalRead(1) // получить сост. датчика петли 2
#define getLOOP3 digitalRead(2) // получить сост. датчика петли 3

#define getUpOpen digitalRead(3)    // получить сост. датчика верхн. ворот при открытии
#define getUpClose digitalRead(4)   // получить сост. датчика верхн. ворот при закрытии
#define getDownOopen digitalRead(5) // получить сост. датчика нижн ворот при открытии
#define getDownClose digitalRead(6) // получить сост. датчика нижн ворот при закрытии

#define getSensor digitalRead(10) // получить сигнал нажатия кнопки пульта верхн. ворот

#define relayUpGatesH digitalWrite(13, HIGH)   // сигнал на реле -> открытие верхних ворот
#define relayUpGatesL digitalWrite(13, LOW)    // сигнал на реле -> закрытие верхних ворот
#define relayDownGatesH digitalWrite(14, HIGH) // сигнал на реле -> открытие нижних ворот
#define relayDownGatesL digitalWrite(14, LOW)  // сигнал на реле -> закрытие нижних ворот

void lcdMain(void);
unsigned long delayTime;
struct gates
{
public:
    bool gUOpen, // верхние откр
        gUClose, // верхние закрыты
        gDOpen,  // нижние откр
        gDClose; // нижние закрыты

    bool loop1, loop2, loop3; //петля 1,2,3
};

class Gates
{

public:
    gates posGates;

    Gates() {}

public:
    virtual void TypeLogic() // переопределяемый метод
    {
    }

    void getPosGates() // запись состояния пинов в переменные
    {
        posGates.loop1 = getLOOP1;
        posGates.loop2 = getLOOP2;
        posGates.loop3 = getLOOP3;

        posGates.gUOpen = getUpOpen;
        posGates.gUClose = getUpClose;
        posGates.gDOpen = getDownOopen;
        posGates.gDClose = getDownClose;
    }

    void mainLogic()
    {
        if (!digitalRead(10) == true) // нажали на пульт верхн. ворот
        {
            digitalWrite(11, HIGH);         // вкл. светофор проезд вниз
            unsigned long waitTime = 10000; // установка тиков 10сек.

            if (waitOpenUpGates(waitTime)) // если во время ожидания откр. верхн. ворот сигнал с датчика получен
            {
                boolean downGO = downGateOpened(15000); // если true-датчик сработал за заданное время,false-не сработал
            }
        }
        else // если за выделенное время датчик открытия верхних ворот не сработалв
        {
        }
    }

    boolean downGateOpened(unsigned long waitTime) // ожидаем открытие нижних ворот
    {
        relayDownGatesH; // открытие нижних ворот

        unsigned long realTime = millis();
        while (((millis() - realTime) < waitTime))
        {
            if (getUpOpen == true) // сработал датчик открытия ворот
                return true;
        }
        return false; // время вышло (датчик открытия ворот молчит)
    }

    boolean waitOpenUpGates(unsigned long waitTime) // ожидаем открытие верхних ворот
    {
        unsigned long realTime = millis();
        while (((millis() - realTime) < waitTime))
        {
            if (getUpOpen == true) // сработал датчик открытия ворот
                return true;
        }
        return false; // время вышло (датчик открытия ворот молчит)
    }

    ~Gates(){};
};

class LogicDay : Gates
{
public:
    void Job()
    {
    }
};

class LogicNight : Gates
{
    void Job()
    {
    }
};

void settingPins()
{
    pinMode(0, INPUT_PULLUP); // петля 1 (верх)
    pinMode(1, INPUT_PULLUP); // петля 2 (центр)
    pinMode(2, INPUT_PULLUP); // петля 3 (низ)
    pinMode(3, INPUT_PULLUP); // датчик верхн. ворота откр.
    pinMode(4, INPUT_PULLUP); // датчик верхн. ворота закрыты
    pinMode(5, INPUT_PULLUP); // датчик нижн. ворота откр.
    pinMode(6, INPUT_PULLUP); // датчик нижн. ворота закрыты

    pinMode(10, INPUT_PULLUP); // пульт

    pinMode(7, INPUT_PULLUP); // кнопка 1
    pinMode(8, INPUT_PULLUP); // кнопка 2
    pinMode(9, INPUT_PULLUP); // кнопка 3

    pinMode(11, OUTPUT); // реле светофор проезд вниз
    pinMode(12, OUTPUT); // реле светофор проезд вверх

    pinMode(13, OUTPUT); // реле открытия/закрытия верхних ворот
    pinMode(14, OUTPUT); // реле открытия/закрытия нижних ворот
}
