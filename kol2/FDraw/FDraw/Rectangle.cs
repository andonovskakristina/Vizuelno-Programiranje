using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDraw
{
    [Serializable]
    public class Rectangle
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public Color Color { get; set; }
        public bool IsSelected { get; set; }

        public Rectangle(int X, int Y, int Width, int Height, Color Color)
        {
            this.X = X;
            this.Y = Y;
            this.Width = Width;
            this.Height = Height;
            this.Color = Color;
            IsSelected = false;
        }

        public bool IsHit(int x, int y)
        {
            if (x >= X && x <= X + Width && y >= Y && y <= Y + Height)
            {
                IsSelected = true;
                return true;
            }

            return false;
        }

        public void Move(int x, int y)
        {
            if (IsSelected)
            {
                X = x;
                Y = y;
            }
        }

        public void Draw(Graphics g)
        {
            Brush b = new SolidBrush(Color);
            g.FillRectangle(b, X, Y, Width, Height);
            b.Dispose();
        }

        public void DrawDotted(Graphics g)
        {
            Pen p = new Pen(Color.Black, 2);
            p.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            g.DrawRectangle(p, X, Y, Width, Height);
            p.Dispose();
        }
    }
}
