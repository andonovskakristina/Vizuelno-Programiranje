using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygons
{
    public class PolygonDoc
    {
        public List<Polygon> Polygons { get; set; }
        public Polygon CurrentPolygon { get; set; }
        public Color CurrentColor { get; set; }
        public Point FirstPoint { get; set; }
        public Point CurrentPoint { get; set; }
        public bool IsHit { get; set; }

        public PolygonDoc()
        {
            Polygons = new List<Polygon>();
            CurrentColor = Color.Blue;
            FirstPoint = Point.Empty;
            CurrentPoint = Point.Empty;
            IsHit = false;
        }

        public void Click(Point Point)
        {
            if(FirstPoint.IsEmpty)
            {
                FirstPoint = Point;
                CurrentPolygon = new Polygon(CurrentColor);
                CurrentPolygon.AddPoint(Point);
            }
            else
            {
                CurrentPolygon.AddPoint(Point);
                
                if(IsHit)
                {
                    FirstPoint = Point.Empty;
                    CurrentPolygon.IsClosed = true;
                    Polygons.Add(CurrentPolygon);
                    CurrentPolygon = null;
                }
            }
        }

        public void Move(Point Point)
        {
            CurrentPoint = Point;
            IsHit = false;

            if(CurrentPolygon != null)
            {
                if(CurrentPolygon.Points.Count > 2)
                {
                    IsHit = Distance(FirstPoint, CurrentPoint) <= 5 * 5;
                }
            }
        }

        public int Distance(Point p1, Point p2)
        {
            return (p1.X - p2.X) * (p1.X - p2.X) + (p1.Y - p2.Y) * (p1.Y - p2.Y);
        }

        public void Draw(Graphics g)
        {
            foreach(Polygon polygon in Polygons)
            {
                polygon.Draw(g);
            }

            if(!FirstPoint.IsEmpty && CurrentPolygon.Points.Count > 1)
            {
                CurrentPolygon.Draw(g);

                Pen pen = new Pen(Color.Black, 1);
                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                g.DrawLine(pen, CurrentPolygon.LastPoint, CurrentPoint);
                if (IsHit)
                {
                    g.DrawEllipse(pen, FirstPoint.X - 5, FirstPoint.Y - 5,
                        10, 10);
                }
                pen.Dispose();
            }
        }
    }
}
