using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygons
{
    public class Polygon
    {
        public List<Point> Points { get; set; }
        public Color Color { get; set; }
        public bool IsClosed { get; set; }

        public Polygon(Color Color)
        {
            this.Color = Color;
            Points = new List<Point>();
            IsClosed = false;
        }

        public void AddPoint(Point Point)
        {
            Points.Add(Point);
        }

        public void Draw(Graphics g)
        {
            if (IsClosed)
            {
                Brush brush = new SolidBrush(Color);
                g.FillPolygon(brush, Points.ToArray());
                brush.Dispose();
            }
            else
            {
                Pen pen = new Pen(Color.Black, 1);
                g.DrawLines(pen, Points.ToArray());
                pen.Dispose();
            }
        }

        public Point LastPoint
        {
            get
            {
                return Points[Points.Count - 1];
            }
        }
    }
}
