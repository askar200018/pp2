using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Example8
{
    class Pen
    {
        public int x, y;
        public char sign = '#';
        public Pen()
        {
            x = 0;
            y = 10;
        }
        public void Draw()
        {
            while (true)
            {
                Console.SetCursorPosition(x, y);
                if (x == 30) x = 0;


                Console.Write(sign);
                Thread.Sleep(200);
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
