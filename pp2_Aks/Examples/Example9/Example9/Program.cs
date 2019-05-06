using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;

namespace Example9
{
    class Point
    {
        public int x;
        public int y;
        public char sign;
        public Point() { }
        public Point(int x, int y, char sign)
        {
            this.x = x;
            this.y = y;
            this.sign = sign;
        }
        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sign = p.sign;
        }
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sign);
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("car.txt");
            string s  = "";
            List<Point> car = new List<Point>();
            int y = 0;
            while ((s = sr.ReadLine()) != null)
            {
                for (int x = 0; x < s.Length; x++)
                    if (s[x] == '*')
                    {
                        car.Add(new Point(x, y, '#'));
                    }
                y++;
            }
            sr.Close();
            //Console.SetCursorPosition()
            while (true)
            {
                //Console.Clear();
                int x = 0;
                for (int i = 0; i < car.Count; i++)
                {
                    Console.SetCursorPosition(x, 10);
                    car[i].Draw();
                    Thread.Sleep(200);
                }
                x++;
            }
        }
    }
}
