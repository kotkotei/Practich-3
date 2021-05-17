using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {//Варианто 10 задание 1
            Console.WriteLine("Введиету 2-ух значчисло");
            string s = Console.ReadLine();
            int i = 0, j = 1;
            while (i < s.Length && j < s.Length)
            {
                if (s[i] == 'a' || s[j] == 'a')
                {
                    Console.WriteLine("Число содержит a");
                }
                else
                {
                    Console.WriteLine("В числе нет a");
                }
                break;
            }
            Console.ReadKey();


        }
    }
}
