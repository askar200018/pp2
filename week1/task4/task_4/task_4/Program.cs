using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();//считываем с консоли
            int n = int.Parse(s1);//переводим строку в число черз парс
            for(int  i = 0; i < n; i++)//создаем цикл
            {
                for(int j = 0; j <= i; j++)//второй цикл до i включительно
                {
                    Console.Write("[*]");// печатаем звездочку
                }
                Console.WriteLine();// переводим на другую строку
            }
        }
    }
}
