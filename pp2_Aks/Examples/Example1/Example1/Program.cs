using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Example1
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread[] threads = new Thread[3];
            for(int i = 0; i < 3; i++)
            {
                threads[i] = new Thread(Print);
                threads[i].Name = "thread" + i;
                threads[i].Start();
            }
        }
        static void Print()
        {
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine(Thread.CurrentThread.Name);
            }
        }
    }
}
