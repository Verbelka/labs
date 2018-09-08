using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Papa_Mama
{
    class Pa_Ma
    {
        string Str;
        int amount;
        int time;
        public static int Messages { get; set; }

        public Pa_Ma(string s, int a, int t)
        {
            this.Str = s;
            this.amount = a;
            this.time = t;
        }

        public void Work()
        {
            while(true)
            {
                if (amount != 0 && Messages != 0)
                {
                    amount--;
                    Messages--;
                    Thread.Sleep(time);
                    Console.WriteLine(Str);
                }
                else
                    Thread.CurrentThread.Abort();
            }
        }

    }
}
