using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aerodromi
{
    public partial class DodadiAerodrom : Form
    {
        public Aerodrom Aerodrom { get; set; }

        public DodadiAerodrom()
        {
            InitializeComponent();
        }

        private void tbGrad_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(tbGrad.Text))
            {
                errorProvider1.SetError(tbGrad, "Полето за внес на град е задолжително!");
                e.Cancel = true;
            } else
            {
                errorProvider1.SetError(tbGrad, null);
                e.Cancel = false;
            }
        }

        private void tbIme_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbIme.Text))
            {
                errorProvider1.SetError(tbIme, "Полето за внес на име е задолжително!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbIme, null);
                e.Cancel = false;
            }
        }

        private void mtbKratenka_Validating(object sender, CancelEventArgs e)
        {
            if(mtbKratenka.Text.Length != 3)
            {
                errorProvider1.SetError(mtbKratenka, "Кратенката мора да има точно 3 големи букви!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(mtbKratenka, null);
                e.Cancel = false;
            }
        }

        private void btnZacuvaj_Click(object sender, EventArgs e)
        {
            Aerodrom = new Aerodrom();
            Aerodrom.Grad = tbGrad.Text;
            Aerodrom.Ime = tbIme.Text;
            Aerodrom.Kratenka = mtbKratenka.Text;

            DialogResult = DialogResult.OK;
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
