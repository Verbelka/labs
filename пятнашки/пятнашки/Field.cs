using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace пятнашки
{
    class Field
    {
        public int Size = 4;
        public int[,] Numbers;
        Random rand = new Random();

        public Field()
        {
            Numbers = new int[Size, Size];
            Start();
        }

        public void Start()
        {
            for (int i = 0; i < Size; i++)
                for (int j = 0; j < Size; j++)
                    Numbers[i, j] = i * Size + j + 1;
        }

        private void Move(int c1, int r1, int c2, int r2)
        {
            Numbers[c1, r1] = Numbers[c2, r2];
            Numbers[c2, r2] = 16;
        }

        public void ChangePosition(int x, int y)
        {
            if (y + 1 <= 3 && Numbers[x, y + 1] == 16)//empty - left
                Move(x, y + 1, x, y);
            if (x - 1 >= 0 && Numbers[x - 1, y] == 16)//empty - top
                Move(x - 1, y, x, y);
            if (x + 1 <= 3 && Numbers[x + 1, y] == 16)//empty - bottom
                Move(x + 1, y, x, y);
            if (y - 1 >= 0 && Numbers[x, y - 1] == 16)//empty - right
                Move(x, y - 1, x, y);
        }

        public void Mix()
        {
            for (int i = 0; i < 10000; i++)
                ChangePosition(rand.Next(Size), rand.Next(Size));
        }

        public void Read()
        {
            string path = "Memory.txt";
            StreamReader file = new StreamReader(path);
            try
            {
                for (int i = 0; i < Size; i++)
                {
                    string[] Buff = (file.ReadLine()).Split(' ');
                    for (int j = 0; j < Size; j++)
                        Numbers[i, j] = Int32.Parse(Buff[j]);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Неверное чтение из {0}. Сообщение: " , path,e.Message);
            }
            finally
            {
                if (file != null)
                    file.Close();
            }
        }

        public void Save()
        {
            string path = "Memory.txt";
            StreamWriter file = new StreamWriter(path);
            try
            {
                for (int i = 0; i < Size; i++)
                {
                    for (int j = 0; j < Size; j++)
                        file.Write(Numbers[i, j] + " ");
                    file.WriteLine();
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Неверная запись в  {0}. Сообщение:", path, e.Message);
            }
            finally
            {
                if (file != null)
                    file.Close();
            }
        }
    };
}
