using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    [Serializable]
    public class Circle
    {
        public static int RADIUS = 25;
        public int X { get; set; }
        public int Y { get; set; }
        public Color Color { get; set; }

        public Circle() { }

        public Circle(int X, int Y, Color Color)
        {
            this.X = X;
            this.Y = Y;
            this.Color = Color;
        }

        public void Draw(Graphics g)
        {
            Brush brush = new SolidBrush(Color);
            g.FillEllipse(brush, X - RADIUS, Y - RADIUS, RADIUS * 2, RADIUS * 2);
            brush.Dispose();
        }
    }
}
