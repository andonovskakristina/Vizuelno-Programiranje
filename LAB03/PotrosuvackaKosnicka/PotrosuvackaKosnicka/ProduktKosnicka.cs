using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotrosuvackaKosnicka
{
    public class ProduktKosnicka
    {
        public Produkt Produkt { get;set; }
        public int Kolicina { get; set; }
        public int Vkupno { get; set; }

        public ProduktKosnicka() { }

        public ProduktKosnicka(Produkt Produkt, int Kolicina)
        {
            this.Produkt = Produkt;
            this.Kolicina = Kolicina;
            Vkupno = Kolicina * Produkt.Cena;
        }

        public override string ToString()
        {
            return string.Format("{0} {1:0.00} x {2:0.00} = {3:0.00}", Produkt.Ime, Kolicina, Produkt.Cena, Vkupno);
        }
    }
}
