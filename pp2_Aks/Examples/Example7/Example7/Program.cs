using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Example7
{
    public class Pen
    {
        public char sign;
        public int x, y;

        public Pen()
        {
            sign = '#';
            x = 0;
            y = 10;
        }
        public void Draw()
        {
            //bool isRed = false;
            Console.ForegroundColor = ConsoleColor.Blue;
            while (true)
            {
                if (Console.ForegroundColor == ConsoleColor.Blue) Console.ForegroundColor = ConsoleColor.Red;
                else Console.ForegroundColor = ConsoleColor.Blue;

                Console.SetCursorPosition(x, y);
                if (x == 30)
                {

                    //isRed = !isRed;

                    x = 0;
                }
                for(int i = 0; i <= 30; i++)
                {
                    Console.Write(sign);
                    Thread.Sleep(100);
                }
                //Console.ForegroundColor = ConsoleColor.Red;

                //for ( int i = 0; i <= 30; i++)
                //{
                //    Console.SetCursorPosition (i, 10);
                //    Console.ForegroundColor = ConsoleColor.Red;
                //    Console.Write(sign);
                //    Thread.Sleep(200);
                //}
                //for (int i = 0; i <= 30; i++)
                //{
                //    Console.SetCursorPosition(i, 10);
                //    Console.ForegroundColor = ConsoleColor.Blue;
                //    Console.Write(sign);
                //    Thread.Sleep(200);
                //}
                x++;
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Pen pen = new Pen();
            Thread thread = new Thread(pen.Draw);
            thread.Start();
        }
    }
}
