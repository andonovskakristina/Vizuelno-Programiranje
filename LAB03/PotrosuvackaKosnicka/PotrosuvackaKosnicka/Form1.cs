using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PotrosuvackaKosnicka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Azuriraj()
        {
            tbIme.Clear();
            tbKategorija.Clear();
            tbCena.Clear();

            if(lbListaProdukti.SelectedIndex != -1)
            {
                tbIme.Text = ((Produkt)lbListaProdukti.SelectedItem).Ime;
                tbKategorija.Text = ((Produkt)lbListaProdukti.SelectedItem).Kategorija;
                tbCena.Text = string.Format("{0:0.00}", ((Produkt)lbListaProdukti.SelectedItem).Cena);
            }
        }

        private void AzurirajVkupno()
        {
            tbVkupno.Clear();

            int vkupno = 0;
            if (lbKosnicka.Items != null)
            {
                foreach (ProduktKosnicka produkt in lbKosnicka.Items)
                {
                    vkupno += produkt.Vkupno;
                }

                tbVkupno.Text = string.Format("{0:0.00}", vkupno);
            }
        }

        private void btnIsprazniListaProdukti_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Дали сте сигурни дека сакате да ја испразните листата со продукти?", "Испразни ја листата?", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                lbListaProdukti.Items.Clear();
                Azuriraj();

                lbKosnicka.Items.Clear();
                AzurirajVkupno();
            }
        }

        private void btnDodadiNovProdukt_Click(object sender, EventArgs e)
        {
            DodadiNovProdukt forma = new DodadiNovProdukt();
            forma.ShowDialog();

            if(forma.DialogResult == DialogResult.OK)
            {
                lbListaProdukti.Items.Add(forma.Produkt);
                Azuriraj();
            }
        }

        private void lbListaProdukti_SelectedIndexChanged(object sender, EventArgs e)
        {
            Azuriraj();
        }

        private void btnIzbrisiProdukt_Click(object sender, EventArgs e)
        {
            if(lbListaProdukti.SelectedIndex != -1)
            {
                List<ProduktKosnicka> lista = new List<ProduktKosnicka>();
                foreach (ProduktKosnicka produkt in lbKosnicka.Items)
                {
                    if (!produkt.Produkt.Equals(lbListaProdukti.SelectedItem))
                    {
                        lista.Add(produkt);
                    }
                }

                lbKosnicka.Items.Clear();
                foreach(ProduktKosnicka produkt in lista)
                {
                    lbKosnicka.Items.Add(produkt);
                }

                lbListaProdukti.Items.Remove(lbListaProdukti.SelectedItem);
                Azuriraj();
                AzurirajVkupno();
            }
            else
            {
                MessageBox.Show("Селектирајте го продуктот што сакате да го избришете!");
            }
        }

        private void btnIsprazniKosnicka_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Дали сте сигурни дека сакате да ја испразните кошничката?", "Испразни ја кошничката?", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                lbKosnicka.Items.Clear();
                AzurirajVkupno();
            }
        }

        private void btnDodadiVoKosnicka_Click(object sender, EventArgs e)
        {
            if (lbListaProdukti.SelectedIndex != -1)
            {
                ProduktKosnicka Produkt = new ProduktKosnicka((Produkt)lbListaProdukti.SelectedItem, (int)nudKolicina.Value);
                lbKosnicka.Items.Add(Produkt);
                AzurirajVkupno();
            }
            else
            {
                MessageBox.Show("Селектирајте го продуктот што сакате да го додадете во кошничката!");
            }
        }

        private void btnIzbrisiOdKosnicka_Click(object sender, EventArgs e)
        {
            if (lbKosnicka.SelectedIndex != -1)
            {
                lbKosnicka.Items.Remove(lbKosnicka.SelectedItem);
                AzurirajVkupno();
            }
            else
            {
                MessageBox.Show("Селектирајте го продуктот што сакате да го избришете од кошничката!");
            }
        }
    }
}
