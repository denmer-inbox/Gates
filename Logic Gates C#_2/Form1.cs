using System;
using System.Drawing;
using System.Windows.Forms;

namespace Logic_Gates
{
    public partial class Form1 : Form
    {

        private bool block1, block2, LDOWN,
                     LUP, SQUP1, SQUP0, SQDOWN1, SQDOWN0,
                     sensor, sensFlag,
                     Fl1, Fl2, Fl3, Floop1, Floop2, Floop3,
                     toggleBut = true,
                     gateUpIsOpened, signalOpenUp, signalOpenDown;

        private bool[] step;

        private int timDo, timUp;

        int carXpos = 978;

        private void Reset()
        {
            block1 = false;
            block2 = false;
            LDOWN = false;
            LUP = false;
            loopClr();
            Fl1 = false;
            Fl2 = false;
            Fl3 = false;
            timDo = 30;
            timUp = 30;
            SQUP1 = false;      // концевик положения открыто
            SQUP0 = true;      // концевик положения закрыто
            SQDOWN1 = false;      // концевик положения открыто
            SQDOWN0 = true;      // концевик положения закрыто
            sensor = false;
            sensFlag = true;
            this.step = new bool[] { true, false, false, false, false, false, false, false };
            signalOpenDown = false;
            signalOpenUp = false;
            gateUpIsOpened = false;
            timerDown.Stop();
            timerUp.Stop();

            info.AppendText("----- ИСХОДНОЕ СОСТОЯНИЕ -----\n");

            Console.Beep(1700, 100);
            Console.Beep(1700, 300);
        }

        public Form1()
        {
            InitializeComponent();
            Reset();
            toggleCheck(null, null);
            timer1.Start();
        }

        private void b_sqdown0(object sender, EventArgs e)
        {
            SQDOWN0 = true;
            SQDOWN1 = false;
            info.AppendText("нижние ворота закрыты\n");
        }

        private void b_squp1(object sender, EventArgs e)  // концевик SQUP1 верхн ворота открыто
        {
            SQUP1 = true;
            SQUP0 = false;
            info.AppendText("верхние ворота открыты\n");
        }

        private void Fire_Click(object sender, EventArgs e)
        {
            info.AppendText("сигнал пожарной тревоги\n");
        }

        private void ButDownUP_Click(object sender, EventArgs e)
        {
            info.AppendText("кнопка ВВЕРХ\n");
            if (!gateUpIsOpened)
            {
                gateUpIsOpened = true;
                SQDOWN0 = false;        // открытие нижних ворот 
            }
        }

        private void ButDownDOWN_Click(object sender, EventArgs e)
        {
            info.AppendText("кнопка ВНИЗ\n");
        }

        private void controlCar(object sender, KeyEventArgs e)
        {

            if (e.KeyValue == 68)
            {
                carXpos += 5;
                if (carXpos >= 978) carXpos = 978;
                carImage.Image = Properties.Resources.carDown;
            }

            if (e.KeyValue == 65)
            {
                carXpos -= 5;
                if (carXpos <= -213) carXpos = -213;
                carImage.Image = Properties.Resources.carUp;
            }

            carImage.Location = new Point(carXpos, 152);

            Console.WriteLine(carXpos);
        }

        private void b_sqdown1(object sender, EventArgs e)// концевик нижних ворот на открытие
        {
            SQDOWN1 = true;
            SQDOWN0 = false;
            info.AppendText("нижние ворота открыты\n");
        }

        private void b_squp0(object sender, EventArgs e) // концевик верхних ворот на закрытие
        {
            SQUP0 = true;       // концевик закрыто активен!
            SQUP1 = false;
            info.AppendText("верхние ворота закрыты\n");
        }

        #region Sens

        private void b_sense(object sender, EventArgs e)  // Пульт ДУ
        {
            info.AppendText("нажал кнопку пульта\n");
            sensor = true;
        }

        #endregion Sens

        private void Start(object sender, EventArgs e)
        {
            timDown.Text = this.timDo.ToString();
            timUP.Text = timUp.ToString();
            WorkingModel();

            if (!gateUpIsOpened)
            {
                if (timDo != 30 && block1 == false) TLDOWN.Visible = true;      // включить светофор проезд вниз
                else if (SQDOWN0 == true) TLDOWN.Visible = false;      // выключить светофор проезд вниз

                if (timUp != 30 && block2 == false) TLUP.Visible = true;      // включить светофор проезд вверх
                else if (SQUP0 == true) TLUP.Visible = false;      // выключить светофор проезд вверх ✔
            }

            if (!block1)
            {



                if (step[0] && sensor)
                {
                    step[0] = false;
                    step[1] = true;

                    timerDown.Start();
                    SQUP0 = false;
                }

                if (step[1] && SQUP1)
                {
                    step[1] = false;
                    step[2] = true;

                    SQDOWN0 = false;
                }

                if (step[2] && Fl1)
                {
                    step[2] = false;
                    step[3] = true;
                }

                if (step[3] && Fl2)
                {
                    step[3] = false;
                    step[4] = true;
                }

                if (step[4] && SQDOWN1)
                {
                    step[4] = false;
                    step[5] = true;
                }

                if (step[5])
                {
                    if (!SQDOWN1 && (Fl1 || Fl2))
                    {
                        step[5] = false;
                        step[4] = true;

                        Console.WriteLine("сигнал на открытие нижних ворот A");
                    }

                    if (Fl3)
                    {
                        step[5] = false;
                        step[6] = true;
                    }
                }

                if (step[6])
                {

                    if (!SQDOWN1 && (Fl1 || Fl2))
                    {
                        step[6] = false;
                        step[4] = true;

                        Console.WriteLine("сигнал на открытие нижних ворот B");
                    }

                    if (SQDOWN0 && !Fl1 && !Fl2) Reset();

                }
            }

            if (signalOpenUp) ;
            if (signalOpenDown) ;

            selectLoop();
        }

        private void timDOO(object sender, EventArgs e)
        {
            Console.WriteLine($"block1 {0}\t\tblock2 {1}", block1, block2);

            Console.Beep(1000, 100);
            timDo--;
            if (timDo <= 0)
            {
                timerDown.Stop();
                timDo = 30;
                Reset();
            }
        }

        private void timUPP(object sender, EventArgs e)
        {
            Console.Beep(1000, 100);
            timUp--;
            if (timUp <= 0)
            {
                timerUp.Stop();
                timUp = 30;
                Reset();
            }
        }

        void selectLoop()
        {
            butLoop1.BackgroundImage = Fl1 ? Properties.Resources.loop : Properties.Resources.loopsel;
            butLoop2.BackgroundImage = Fl2 ? Properties.Resources.loop : Properties.Resources.loopsel;
            butLoop3.BackgroundImage = Fl3 ? Properties.Resources.loop : Properties.Resources.loopsel;
        }

        private void restart(object sender, EventArgs e)
        {
            Reset();
        }

        private void loop1_Click(object sender, EventArgs e)
        {
            Fl1 = !Fl1;
            loopClr(1);
            string text = "петля 1 - " + (Fl1 ? "занята\n" : "свободна\n");
            info.AppendText(text);
        }

        private void loop2_Click(object sender, EventArgs e)
        {
            Fl2 = !Fl2;
            loopClr(2);
            string text = "петля 2 - " + (Fl2 ? "занята\n" : "свободна\n");
            info.AppendText(text);
        }

        private void loop3_Click(object sender, EventArgs e)
        {
            Fl3 = !Fl3;
            loopClr(3);
            string text = "петля 3 - " + (Fl3 ? "занята\n" : "свободна\n");
            info.AppendText(text);
        }

        private void loopClr(byte a)
        {
            loopClr();
            Floop1 = a == 1 ? true : false;
            Floop2 = a == 2 ? true : false;
            Floop3 = a == 3 ? true : false;
        }

        private void loopClr()
        {
            Floop1 = false;
            Floop2 = false;
            Floop3 = false;
        }

        void FlReset()
        {
            Fl1 = Fl2 = Fl3 = false;
        }

        private void WorkingModel()
        {
            // butSense.Visible = (bool)sensFlag;

            if (SQUP1)
            {
                //         info.AppendText("верхние ворота открыты\n");
                pictureBox3.Image = Properties.Resources.rolletnye;
                openUP.Visible = false;
            }
            if (SQUP0)
            {
                //        info.AppendText("верхние ворота закрыты\n");
                pictureBox3.Image = Properties.Resources.rolletnye1;
                openUP.Visible = false;
            }

            if (!SQUP0 && !SQUP1)
            {
                //       info.AppendText("происходит открытие ворот\n");
                openUP.Visible = true;      // открытие верхних ворот
            }

            if (SQDOWN0)
            {
                //      info.AppendText("нижние ворота закрыты\n");
                pictureBox2.Image = Properties.Resources.rolletnye1;
                openDOWN.Visible = false;
            }

            if (SQDOWN1)
            {
                //          info.AppendText("нижние ворота открыты\n");
                pictureBox2.Image = Properties.Resources.rolletnye;
                openDOWN.Visible = false;
            }

            if (SQDOWN0 || SQDOWN1)
            {
                openDOWN.Visible = false;
            }

            if (!SQDOWN0 && !SQDOWN1) openDOWN.Visible = true;

            IUP1.Text = retBool(SQUP1);
            IUP0.Text = retBool(SQUP0);
            IDOWN1.Text = retBool(SQDOWN1);
            iDOWN0.Text = retBool(SQDOWN0);

        }

        string retBool(bool a)
        {
            return a ? "вкл" : "выкл";
        }

        void toggleCheck(object sender, MouseEventArgs e)
        {
            toggleBut = !toggleBut;
            DayNight.Text = (toggleBut ? "День" : "Ночь");
            string text = "Режим " + DayNight.Text + "\n";
            info.AppendText(text);
            toggleButton.Image = toggleBut ? Properties.Resources.toggleON : Properties.Resources.toggleOFF;

        }

        private void Info_TextChanged(object sender, EventArgs e)
        {
            info.ScrollToCaret();
        }

        private void TimDown_Click(object sender, EventArgs e)
        {
            timDo = 29;
        }

        private void TimUP_Click(object sender, EventArgs e)
        {
            timUp = 29;
        }

    }
}