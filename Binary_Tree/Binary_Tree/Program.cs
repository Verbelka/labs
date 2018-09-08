using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Binary_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Tree_New T = new Tree_New();
                StreamReader file = new StreamReader("C:\\Users\\Veronika\\Desktop\\универ\\DATA.txt");
                string name = @"C:\\Users\\Veronika\\Desktop\\универ\\DATA.txt";
                string[] read_text = File.ReadAllLines(name);
                if (!File.Exists(name) || read_text.Length == 0)
                    Console.WriteLine("Файл не существует или пуст!");
                else
                {
                    using (file)
                    {
                        for (int i = 0; i < read_text.Length; i++)
                        {
                            if (T.Insert(Convert.ToInt32(read_text[i])))
                                Console.WriteLine("Число {0} добавлено в дерево ", read_text[i]);
                            else
                                Console.WriteLine("Число {0} не добавлено ", read_text[i]);
                        }
                    }
                    Console.WriteLine("\nДерево:\n{0}", T);
                    Console.WriteLine("\nВведите уровень дерева : ");
                    int k = Int32.Parse(Console.ReadLine());
                    if (T.Del_Son(k))
                        Console.WriteLine("Вершина удалена.");
                    else
                        Console.WriteLine("Не удалось удалить вершину.");
                    Console.WriteLine("\nДерево:\n{0}", T);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
