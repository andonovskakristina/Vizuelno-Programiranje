using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportsBets
{
    public class Ticket
    {
        public Game game { get; set; }
        public int Tip { get; set; }

        public override string ToString()
        {
            return string.Format("{0} vs {1} : {2}", game.Home.Name, game.Guest.Name, Tip == 0 ? "1" : Tip == 1 ? "X" : "2");
        }
    }
}
