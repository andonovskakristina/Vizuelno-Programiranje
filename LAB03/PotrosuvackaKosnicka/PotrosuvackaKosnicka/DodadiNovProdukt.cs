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
    public partial class DodadiNovProdukt : Form
    {
        public Produkt Produkt { get; set; }
        public DodadiNovProdukt()
        {
            InitializeComponent();
        }

        private void tbIme_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(tbIme.Text))
            {
                errorProvider1.SetError(tbIme, "Полето за внес на име на продукт е задолжително!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbIme, null);
                e.Cancel = false;
            }
        }

        private void tbCena_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbCena.Text))
            {
                errorProvider1.SetError(tbCena, "Полето за внес на цена на продукт е задолжително!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbCena, null);
                e.Cancel = false;
            }
        }

        private void tbKategorija_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbKategorija.Text))
            {
                errorProvider1.SetError(tbKategorija, "Полето за внес на цена на продукт е задолжително!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbKategorija, null);
                e.Cancel = false;
            }
        }

        private void btnDodadi_Click(object sender, EventArgs e)
        {
            Produkt = new Produkt();
            Produkt.Ime = tbIme.Text;
            Produkt.Kategorija = tbKategorija.Text;

            if (int.TryParse(tbCena.Text, out int cena))
            {
                Produkt.Cena = Convert.ToInt32(cena);
            }
            else
            {
                MessageBox.Show("Цената мора да се состои само од цифри!");
                return;
            }

            DialogResult = DialogResult.OK;
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
