using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovingObject
{
    public class Circle
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Radius { get; set; }
        public Color Color { get; set; }
        public bool IsClicked { get; set; }
        public bool IsGrowing { get; set; }

        public static int MAX_RADIUS = 50;
        public static int MIN_RADIUS = 10;

        public Circle(int x, int y, int radius, Color color)
        {
            X = x;
            Y = y;
            Radius = radius;
            Color = color;
            IsClicked = false;
            IsGrowing = true;
        }

        public bool IsHit(int x, int y)
        {
            double d = Math.Sqrt((X - x) * (X - x) + (Y - y) * (Y - y));
            return d <= Radius;
        }

        public void Move(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Draw(Graphics g)
        {
            Brush brush = new SolidBrush(Color);
            g.FillEllipse(brush, X - Radius, Y - Radius, Radius * 2, Radius * 2);
        }

        public bool IsHit(Circle circle)
        {
            double d = Math.Sqrt((X - circle.X) * (X - circle.X) + (Y - circle.Y) * (Y - circle.Y));
            return d <= Radius + circle.Radius;
        }

        public void Growing()
        {
            if(Radius >= MAX_RADIUS)
            {
                IsGrowing = false;
            }
            else if(Radius <= MIN_RADIUS)
            {
                IsGrowing = true;
            }

            if(IsGrowing)
            {
                Radius += 5;
            }
            else
            {
                Radius -= 5;
            }
        }
    }
}
