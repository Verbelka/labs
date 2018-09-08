using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegExp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите название файла : ");
            string name = @Console.ReadLine();
            FileInfo fi = new FileInfo(name);
            int count = 0;
            if (!fi.Exists || fi.Length == 0)
                Console.WriteLine("Файл не существует!");
            else
            {
                StreamReader file = new StreamReader(name);
                string[] read_text = File.ReadAllLines(name);
                if (read_text.Length == 0)
                    Console.WriteLine("Файл пуст!");
                else
                {
                    try
                    {
                        string pattern = @"^((0[1-9]|[12]\d|3[01])\.(0[13578]|1[02])\.((1[89]|20)\d{2}|2100))\b";
                        string pattern_vis = @"^((0[1-9]|[12]\d|30)\.(0[469]|11)\.((1[89]|20)\d{2}|2100))\b";
                        string February = @"^(((0[1-9]|1\d|2[0-8])\.02\.((1[89]|20)\d{2}|2100))|(29\.02\.((1[89]|20)(0[48]|[2468][048]|[13579][26])|2000)))\b";
                        Regex newReg = new Regex(pattern);
                        Regex Reg_Vis = new Regex(pattern_vis);
                        Regex Reg_F = new Regex(February);
                        while (!file.EndOfStream)
                        {
                            string line = file.ReadLine();
                            MatchCollection matches = newReg.Matches(line);
                            MatchCollection matches_vis = Reg_Vis.Matches(line);
                            MatchCollection matches_F = Reg_F.Matches(line);
                            if (matches.Count + matches_vis.Count + matches_F.Count >= 1)
                                count++;
                        }
                        Console.WriteLine("Количество строк : {0}", count);
                    }
                    catch (Exception exc)
                    {
                        Console.WriteLine("Check the data!" + exc);
                    }
                }
            }
        }
    }
}
