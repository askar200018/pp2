using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Example4
{
    class Point
    {
        public int x;
        public int y;
        public Thread thread;
        public Point(int x , int y)
        {
            this.x = x;
            this.y = y;
            thread = new Thread(Print);
        }
        public void Print()
        {

           for(int i = 0; i < 70; i++)
            {
                Console.Write("*");
                Thread.Sleep(300);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point(20, 10);
            point.Print();
        }
    }
}
