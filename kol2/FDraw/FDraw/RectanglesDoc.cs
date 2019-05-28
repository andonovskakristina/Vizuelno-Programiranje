using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDraw
{
    [Serializable]
    public class RectanglesDoc
    {
        public List<Rectangle> Rectangles { get; set; }

        public RectanglesDoc()
        {
            Rectangles = new List<Rectangle>();
        }

        public void AddRectangle(Rectangle r)
        {
            Rectangles.Add(r);
        }

        public bool IsHit(int x, int y)
        {
            foreach (Rectangle rectangle in Rectangles)
            {
                if (rectangle.IsHit(x, y))
                {
                    return true;
                }
            }

            return false;
        }

        public bool Selected()
        {
            foreach (Rectangle rectangle in Rectangles)
            {
                if (rectangle.IsSelected)
                    return true;
            }

            return false;
        }

        public void RefreshSelected()
        {
            foreach (Rectangle rectangle in Rectangles)
            {
                rectangle.IsSelected = false;
            }
        }

        public void Move(int x, int y)
        {
            foreach(Rectangle rectangle in Rectangles)
            {
                rectangle.Move(x, y);
            }
        }

        public void Draw(Graphics g)
        {
            foreach(Rectangle rectangle in Rectangles)
            {
                rectangle.Draw(g);
            }
        }
    }
}
