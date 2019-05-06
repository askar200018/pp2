using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    class Mash
    {
        public GraphicsPath gp1 , gp2;
        public int x, y;
        //public Graphics graphics;
        //Pen pen = new Pen(Color.Black);
        public Mash(int x , int y)
        {
            gp1 = new GraphicsPath();
            gp2 = new GraphicsPath();
            this.x = x;
            this.y = y;
        }
        public void AddFig()
        {
            x += 10;
            if (x + 80>= 780) x = 0;
            gp1.Reset();
            gp2.Reset();
            Point[] poll = new Point[]
            {
                new Point(x , y),
                new Point(x  + 30, y),
                new Point(x  + 30, y - 15),
                new Point(x  + 50, y - 15),
                new Point(x  + 50, y),
                new Point(x  + 80, y),
                new Point(x + 80, y + 20),
                new Point(x , y + 20),
            };
            gp1.AddPolygon(poll);
            gp2.AddEllipse(new Rectangle(x + 15, y + 10, 15, 15));
            gp2.AddEllipse(new Rectangle(x + 55, y + 10, 15, 15));
           // graphics.DrawPath(pen, gp);
        }
    }
}
