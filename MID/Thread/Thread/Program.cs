using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace Thread2
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread = new Thread(F1);
            thread.Start();
        }
        public static void F1()
        {
            int i = 7;
            StreamReader sr = new StreamReader("input.txt");
            string s = sr.ReadToEnd();
            sr.Close();
            Console.Write(s);
            ConsoleKeyInfo consoleKeyInfo = Console.ReadKey();
            while (true)
            {
                if (consoleKeyInfo.Key == ConsoleKey.Spacebar)
                {
                    Console.SetCursorPosition(i, 0);
                    Console.Write("$");
                    Console.SetCursorPosition(i - 1, 0);
                    Console.Write(" ");
                    Thread.Sleep(300);
                    
                }
                i++;

                //Console.SetCursorPosition(i, 0);
                //Console.Write("$");
                //Console.SetCursorPosition(i - 1, 0);
                //Console.Write(" ");
                //Thread.Sleep(300);
            }
        }
    }
}
