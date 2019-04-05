using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotrosuvackaKosnicka
{
    public class Produkt
    {
        public string Ime { get; set; }
        public string Kategorija { get; set; }
        public int Cena { get; set; }

        public Produkt() { }

        public Produkt(string Ime, string Kategorija, int Cena)
        {
            this.Ime = Ime;
            this.Kategorija = Kategorija;
            this.Cena = Cena;
        }

        public override string ToString()
        {
            return Ime;
        }
    }
}
