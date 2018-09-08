using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;

namespace Eventss
{
    class Demonstrator
    {
        public Thread shootThr;
        private Calculator calc;

        public delegate void SetText(string text);
        public static SetText set_t;

        public delegate void StopHandler();
        public  event StopHandler stopCalc;

        public delegate void DemonEventHandler(object sender, EventArgs e);
        public event DemonEventHandler DemonEvent;
        public delegate void ShootEventHandler(object sender, ShootingEventArgs e);
        public event ShootEventHandler ShootEvent;

        public void StopCalc()
        {
            if (DemonEvent != null)
                DemonEvent(this, new EventArgs());
            //stopCalc();
        }

        public void StopShooting()
        {
            if (calc.calcThr.IsAlive)
                throw new Exception("Вычислитель не остановлен");
            else
            {
                if (shootThr != null)
                    shootThr.Abort();
            }
        }

        public void StartShoot()
        {
            shootThr = new Thread(Shooting);
            shootThr.Start();
        }

        public static void Show(object sender, CalculatorEventArgs e)
        {
            try
            {
                string Str;
                Str = "Количество полупростых чисел на промежутке [" + e.begin + ";" + e.end + "] : " + e.amount + "\n";

                set_t = new SetText(SetT);
                Form1.textBox1.Invoke(set_t, Str);
                Thread.Sleep(e.time);

                Calculator calc = new Calculator(e.time);
                calc.Calc += Demonstrator.Show;
                calc.Calculate();
            }
            catch(Exception)
            { }
        }

        public void Shooting(object sender, ShootingEventArgs e)
        {
            try
            {
                Form1.Shooting(e.x, e.y);
                Thread.Sleep(e.time);
            }
            catch (Exception)
            { }
        }

        public static void SetT(string text)
        {
            Form1.textBox1.Text += text;
        }
    };

    class ShootingEventArgs : EventArgs
    {
        public int x;
        public int y;
        public int time;

        public ShootingEventArgs(int x, int y, int t)
        {
            this.y = y;
            this.x = x;
            this.time = t;
        }
    }
}
