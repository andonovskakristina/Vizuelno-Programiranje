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
    public partial class DodadiDestinacija : Form
    {
        public Destinacija Destinacija { get; set; }
        public DodadiDestinacija()
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

        private void btnDodadi_Click(object sender, EventArgs e)
        {
            Destinacija = new Destinacija();
            Destinacija.Ime = tbIme.Text;
            Destinacija.Oddalecenost = (int)nudDolzina.Value;
            Destinacija.Cena = (int)nudCena.Value;

            DialogResult = DialogResult.OK;
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
