using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawLines
{
    [Serializable]
    public class LinesDoc
    {
        public List<Line> Lines { get; set; }

        public LinesDoc()
        {
            Lines = new List<Line>();
        }

        public void Draw(Graphics g)
        {
            foreach(Line line in Lines)
            {
                line.Draw(g);
            }
        }
    }
}
