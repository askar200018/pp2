using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Example2
{
    class MyThread
    {
        public Thread ThreadField;
        public MyThread(string name)
        {
            ThreadField = new Thread(Print);
            ThreadField.Name = name;
        }
        public void Print()
        {
            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine(ThreadField.Name + " выводит " + (i + 1));
            }
            Console.WriteLine(ThreadField.Name + " закончился");
        }
        public void StartThread()
        {
            ThreadField.Start();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyThread t1 = new MyThread("Thread 1");
            MyThread t2 = new MyThread("Thread 2");
            MyThread t3 = new MyThread("Thread 3");
            MyThread t4 = new MyThread("Thread 4");

            t1.StartThread();
            t2.StartThread();
            t3.StartThread();
            t4.StartThread();
            Console.ReadKey();
        }
    }
}
