using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Task2
{

    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int x = 10;
                for(int i = 0; i <= 5; i++)
                {
                    Console.SetCursorPosition(x + i , 10);
                    Console.Write("*");
                    Thread.Sleep(300);
                    Console.Clear();
                } x = 15;
                for (int i = 0; i <= 10; i++)
                {
                    Console.SetCursorPosition(x - i, 10);
                    Console.Write("*");
                    Thread.Sleep(300);
                    Console.Clear();
                } x = 5;
                for (int i = 0; i <= 5; i++)
                {
                    Console.SetCursorPosition(x + i, 10);
                    Console.Write("*");
                    Thread.Sleep(300);
                    Console.Clear();
                }
            }
        }
    }
}
