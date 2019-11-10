#include <Arduino.h>
#include "LCD_1602_RUS.h"
#include <HardwareSerial.h>

#define getLOOP1 digitalRead(0)
#define getLOOP2 digitalRead(1)
#define getLOOP3 digitalRead(2)

#define getUpOpen digitalRead(3)
#define getUpClose digitalRead(4)
#define getDownOopen digitalRead(5)
#define getDownClose digitalRead(6)

void lcdMain(void);

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
    virtual void TypeLogic()
    {
    }

    void getPosGates()
    {
        posGates.loop1 = getLOOP1;
        posGates.loop2 = getLOOP2;
        posGates.loop3 = getLOOP3;

        posGates.gUOpen = getUpOpen;
        posGates.gUClose = getUpClose;
        posGates.gDOpen = getDownOopen;
        posGates.gDClose = getDownClose;
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
    pinMode(0, INPUT_PULLUP);
    pinMode(1, INPUT_PULLUP);
    pinMode(2, INPUT_PULLUP);
    pinMode(3, INPUT_PULLUP);
    pinMode(4, INPUT_PULLUP);
    pinMode(5, INPUT_PULLUP);
    pinMode(6, INPUT_PULLUP);

    pinMode(10, INPUT_PULLUP); // пульт

    pinMode(7, INPUT_PULLUP); // кнопка 1
    pinMode(8, INPUT_PULLUP); // кнопка 2
    pinMode(9, INPUT_PULLUP); // кнопка 3

    pinMode(11, OUTPUT); // светофор проезд вниз
    pinMode(12, OUTPUT); // светофор проезд вверх
}