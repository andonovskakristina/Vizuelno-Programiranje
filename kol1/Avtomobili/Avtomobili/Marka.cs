using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Avtomobili
{
    public class Marka
    {
        public string Ime { get; set; }
        public string Sifra { get; set; }

        public Marka() { }

        public Marka(string Ime, string Sifra)
        {
            this.Ime = Ime;
            this.Sifra = Sifra;
        }

        public override string ToString()
        {
            return string.Format("{0} ({1})", Ime, Sifra);
        }
    }
}
