using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1Trka
{
    public class Vozac
    {
        public string Ime { get; set; }
        public int Vozrast { get; set; }
        public bool PrvVozac { get; set; }

        public List<Krug> Krugovi;

        public Vozac()
        {
            Krugovi = new List<Krug>();
        }

        public override string ToString()
        {
            return string.Format("{0} ({1}) - {2}", Ime, Vozrast, PrvVozac ? "F" : "S");
        }
    }
}
