using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerodromi
{
    public class Aerodrom
    {
        public string Grad { get; set; }
        public string Ime { get; set; }
        public string Kratenka { get; set; }
        public List<Destinacija> Destinacii { get; set; }

        public Aerodrom()
        {
            Destinacii = new List<Destinacija>();
        }

        public Aerodrom(string Grad, string Ime, string Kratenka, List<Destinacija> Destinacii)
        {
            this.Grad = Grad;
            this.Ime = Ime;
            this.Kratenka = Kratenka;
            this.Destinacii = Destinacii;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} - {2}", Kratenka, Ime, Grad);
        }
    }
}
