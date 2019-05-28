using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorCircles
{
    [Serializable]
    public class CirclesDoc
    {
        public List<Circle> Circles { get; set; }

        public CirclesDoc()
        {
            Circles = new List<Circle>();
        }

        public void AddCircle(Circle circle)
        {
            Circles.Add(circle);
        }

        public void Select(int x, int y)
        {
            foreach(Circle circle in Circles)
            {
                if (circle.IsHit(x, y))
                    break;
            }
        }

        public void DeleteSelected()
        {
            for(int i = 0; i < Circles.Count; i++)
            {
                if(Circles[i].IsSelected)
                {
                    Circles.RemoveAt(i);
                    i--;
                }
            }
        }

        public void Draw(Graphics g)
        {
            foreach(Circle circle in Circles)
            {
                circle.Draw(g);
            }
        }
    }
}
