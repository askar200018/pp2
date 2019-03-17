using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Point
    {
        public int x;
        public int y;
        public char sign;
        public Point() { }
        public Point(int x , int y , char sign)
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
}
