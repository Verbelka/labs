using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Papa_Mama
{
    class Program
    {
        static void Main(string[] args)
        {
            int Mess;
            Console.WriteLine("Введите общее количество повторений : ");
            Mess = Int32.Parse(Console.ReadLine());
            Pa_Ma.Messages = Mess;

            Pa_Ma s1 = new Pa_Ma("мяу ", 5, 1359);
            Pa_Ma s2 = new Pa_Ma("гав ", 4, 2251);
            Pa_Ma s3 = new Pa_Ma("пиу ", 2, 1987);

            Thread t1 = new Thread(s1.Work);
            Thread t2 = new Thread(s2.Work);
            Thread t3 = new Thread(s3.Work);

            t1.Start();
            t2.Start();
            t3.Start();
        }
    }
}
