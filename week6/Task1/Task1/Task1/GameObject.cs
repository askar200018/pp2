using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class GameObject 
    {
        public List<Point> body;
        ConsoleColor color;
        public GameObject() { }
        public GameObject(int x , int y , char sign , ConsoleColor color)
        {
            body = new List<Point>();
            body.Add(new Point(x, y, sign));
            this.color = color;
        }
        public void Draw()
        {
            Console.ForegroundColor = color;
            foreach(Point p in body)
            {
                Console.SetCursorPosition(p.x, p.y);
                Console.Write(p.sign);
            }
        }
    }
}
