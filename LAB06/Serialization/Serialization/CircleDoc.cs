using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    [Serializable]
    public class CircleDoc
    {
        public List<Circle> Circles;

        public CircleDoc()
        {
            Circles = new List<Circle>();
        }

        public void Draw(Graphics g)
        {
            foreach (Circle circle in Circles)
            {
                circle.Draw(g);
            }
        }
    }
}
