using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1Trka
{
    public class Krug
    {
        public int Minuti { get; set; }
        public int Sekundi { get; set; }

        public Krug() { }

        public override string ToString()
        {
            return string.Format("{0}:{1}", Minuti, Sekundi);
        }
    }
}
