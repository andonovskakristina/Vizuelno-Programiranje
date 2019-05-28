using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyingBall
{
    [Serializable]
    public class Ball
    {
        public static int Radius = 25;
        public Color Color { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public int Type { get; set; }

        public Ball(int X, int Y, int Type)
        {
            this.X = X;
            this.Y = Y;
            this.Type = Type;

            if (Type == 0)
                Color = Color.Green;
            else if (Type == 1)
                Color = Color.Blue;
            else
                Color = Color.Red;
        }

        public bool IsHit(int x, int y)
        {
            if(Math.Sqrt((x - X) * (x - X) + (y - Y) * (y - Y)) <= Radius)
            {
                return true;
            }

            return false;
        }

        public void ChangeType()
        {
            Type++;

            if (Type == 0)
                Color = Color.Green;
            else if (Type == 1)
                Color = Color.Blue;
            else if (Type == 2)
                Color = Color.Red;
            else
                Color = Color.White;
        }

        public void Move()
        {
            X += 10;
        }

        public void Draw(Graphics g)
        {
            Brush b = new SolidBrush(Color);
            g.FillEllipse(b, X - Radius, Y - Radius, Radius * 2, Radius * 2);
            b.Dispose();
        }
    }
}
