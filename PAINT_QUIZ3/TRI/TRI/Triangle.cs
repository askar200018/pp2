using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRI
{
    class Triangle
    {
        public int x, y;
        public GraphicsPath gp;
        public Triangle(int x , int y)
        {
            this.x = x;
            this.y = y;
            gp = new GraphicsPath();
        }
        Random random = new Random();

        public void Draw()
        {
            //x += 5;
            //y += 5;
            //if (x == 1050) x = 0;
            //if (y >= 545) y = 0;
            gp.Reset();
            int d = random.Next(10, 50);
            int d2 = random.Next(10, 60);
            Point[] points = new Point[]
            {
                new Point(x , y),
                new Point(x + 20, y + 15),
                new Point(x - 20 , y + 15)
            };
            gp.AddPolygon(points);
        }
    }
}
