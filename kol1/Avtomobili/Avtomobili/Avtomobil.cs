using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avtomobili
{
    public class Avtomobil
    {
        public Marka Marka { get; set; }
        public string Model { get; set; }
        public int Potrosuvacka { get; set; }
        public int Cena { get; set; }

        public Avtomobil() { }

        public override string ToString()
        {
            return string.Format("{0} {1} {2:0.0} {3}", Marka.Ime, Marka, Potrosuvacka, Cena);
        }
    }
}
