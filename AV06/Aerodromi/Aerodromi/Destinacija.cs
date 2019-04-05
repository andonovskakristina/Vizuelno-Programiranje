using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerodromi
{
    public class Destinacija
    {
        public string Ime { get; set; }
        public int Oddalecenost { get; set; }
        public int Cena { get; set; }

        public Destinacija() { }

        public Destinacija(string Ime, int Oddalecenost, int Cena)
        {
            this.Ime = Ime;
            this.Oddalecenost = Oddalecenost;
            this.Cena = Cena;
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} km - {2} EUR", Ime, Oddalecenost, Cena);
        }
    }
}
