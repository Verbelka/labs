using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Eventss
{

    class Calculator
    {
        public Thread calcThr;
        private Demonstrator demonstrator;
        private static bool IsWorking;
        public static int time { get; set; }

        public delegate void CalculatorEventHandler(object sender, CalculatorEventArgs e);
        public event CalculatorEventHandler Calc;

        public void FinishHandler()
        {
           calcThr.Abort();
            IsWorking = false;
            Form1.textBox1.Text += "Stop!\n";
        }

        public Calculator(int t)
        {
            if (t <= 0)
                time = 10;
            Calculator.time = t;
            IsWorking = true;
        }

        public bool Pr_Chislo(int a)
        {
            bool k = true;
            if (a == 1)
                return false;
            for (int u = 2; u <= Math.Sqrt(a); ++u)
                if (a % u == 0)
                    k = false;
            return k;
        }

        public void Calculate()
        {
            int begin, end, amount = 0;
            Random rand = new Random();

            if (IsWorking)
            {
                begin = rand.Next(2, 99999);
                end = rand.Next(begin, 100000);
                int j = 2;

                for (int i = begin; i <= end; i++)//i - проверяемое число
                {
                    double a = Math.Sqrt(i);
                    for (int k = 2; k <= a; k++)
                    {
                        if (i % k == 0 && Pr_Chislo(k))
                        {
                            j = i / k;
                            if (Pr_Chislo(j) && j * k == i)
                            {
                                amount++;
                                break;
                            }
                        }
                    }
                }
                Calc?.Invoke(this, new CalculatorEventArgs(begin, end, amount, time));
            }
        }

        public void SetDemonstrator(Demonstrator demonstrator_)
        {
            demonstrator = demonstrator_;
            demonstrator.DemonEvent += new DemonEventHandler(Stop);
        }

        private void Stop(object sender, EventArgs e)
        {
            if (calcThr != null)
               calcThr.Abort();
        }
    };

    class CalculatorEventArgs : EventArgs
    {
        public int begin;
        public int end;
        public int amount;
        public int time;

        public CalculatorEventArgs(int b, int e, int a, int t)
        {
            begin = b;
            end = e;
            amount = a;
            time = t;
        }
    }
}
