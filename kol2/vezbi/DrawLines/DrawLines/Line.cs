using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawLines
{
    [Serializable]
    public class Line
    {
        public Point Start { get; set; }
        public Point End { get; set; }
        public Color Color { get; set; }
        public int Thickness { get; set; }

        public Line() { }

        public Line(Point Start, Point End, Color Color, int Thickness)
        {
            this.Start = Start;
            this.End = End;
            this.Color = Color;
            this.Thickness = Thickness;
        }

        public void Draw(Graphics g)
        {
            Pen pen = new Pen(Color, Thickness);
            g.DrawLine(pen, Start, End);
            pen.Dispose();
        }
    }
}
