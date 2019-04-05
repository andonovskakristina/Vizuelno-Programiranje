using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsBets
{
    public class Game
    {
        public Team Home { get; set; }
        public Team Guest { get; set; }
        public decimal[] Coefficients { get; set; }
        public string Code { get; set; }

        public Game()
        {
            Coefficients = new decimal[3];
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} vs {2}", Code, Home, Guest);
        }
    }
}
