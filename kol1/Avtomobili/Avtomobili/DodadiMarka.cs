using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avtomobili
{
    public partial class DodadiMarka : Form
    {
        public Marka Marka;
        public DodadiMarka()
        {
            InitializeComponent();
        }

        private void tbIme_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrEmpty(tbIme.Text))
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

        private void tbSifra_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(tbSifra.Text))
            {
                errorProvider1.SetError(tbSifra, "Полето за внес на шифра е задолжително!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(tbSifra, null);
                e.Cancel = false;
            }
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnDodadi_Click(object sender, EventArgs e)
        {
            Marka = new Marka();
            Marka.Ime = tbIme.Text;
            Marka.Sifra = tbSifra.Text;

            DialogResult = DialogResult.OK;
        }
    }
}
