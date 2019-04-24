using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY
{
    class People
    {
        public int x, y;
        public GraphicsPath gp1;
        public GraphicsPath gp2;
        public People(int x , int y)
        {
            this.x = x;
            this.y = y;
            gp1 = new GraphicsPath();
            gp2 = new GraphicsPath();
        }
        public void Move()
        {
            gp1.Reset();
            Point[] point =
            {
                new Point( x , y + 50),
                new Point( x + 50 , y + 70),
                new Point( x + 70 , y + 80),
                new Point( x + 50 , y + 80),
                new Point( x + 50 , y + 130),
                new Point( x, y + 130),
                new Point( x + 50 , y + 130),
                new Point(x + 70 , y + 150)
            };
            gp1.AddPolygon(point);
            gp1.AddEllipse(new Rectangle(x, y, 50, 50));
            
        }
    }
}
