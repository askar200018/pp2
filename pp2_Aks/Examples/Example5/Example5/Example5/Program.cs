using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;


namespace Example5
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                for (int i = 0;i < 10; i++)
                {
                    Console.SetCursorPosition(5 + i, 1);
                    Console.WriteLine("******");
                    Console.SetCursorPosition(5 + i, 2);
                    Console.WriteLine("*    ***");
                    Console.SetCursorPosition(5 + i, 3);
                    Console.WriteLine("******");
                    Console.SetCursorPosition(1 + i, 4);
                    Console.WriteLine("******");
                    Console.SetCursorPosition(1 + i, 5);
                    Console.WriteLine("*    ***");
                    Console.SetCursorPosition(1 + i, 6);
                    Console.WriteLine("******");
                    Thread.Sleep(300);
                    Console.Clear();
                }
            }
        }
    }
}
