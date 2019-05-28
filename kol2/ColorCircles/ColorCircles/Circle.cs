using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorCircles
{
    [Serializable]
    public class Circle
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Radius { get; set; }
        public Color Color { get; set; }
        public bool IsSelected { get; set; }

        public Circle(int X, int Y, int Radius, Color Color)
        {
            this.X = X;
            this.Y = Y;
            this.Radius = Radius;
            this.Color = Color;
            IsSelected = false;
        }

        public bool IsHit(int x, int y)
        {
            if(Math.Sqrt((x - X) * (x - X) + (y - Y) * (y - Y)) <= Radius)
            {
                IsSelected = !IsSelected;
                return true;
            }
            return false;
        }

        public void Draw(Graphics g)
        {
            Brush b = new SolidBrush(Color);
            g.FillEllipse(b, X - Radius, Y - Radius, Radius * 2, Radius * 2);
            b.Dispose();

            if(IsSelected)
            {
                Pen p = new Pen(Color.Red, 5);
                g.DrawEllipse(p, X - Radius, Y - Radius, Radius * 2, Radius * 2);
                p.Dispose();
            }
        }

        public void DrawDotted(Graphics g)
        {
            Pen p = new Pen(Color.Black, 3);
            p.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            g.DrawEllipse(p, X - Radius, Y - Radius, Radius * 2, Radius * 2);
            p.Dispose();
        }
    }
}
