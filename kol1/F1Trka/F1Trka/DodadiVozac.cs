using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F1Trka
{
    public partial class DodadiVozac : Form
    {
        public Vozac Vozac { get; set; }
        public DodadiVozac()
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

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnDodadi_Click(object sender, EventArgs e)
        {
            Vozac = new Vozac();
            Vozac.Ime = tbIme.Text;
            Vozac.Vozrast = (int)nudVozrast.Value;
            Vozac.PrvVozac = cbPrvVozac.Checked;

            DialogResult = DialogResult.OK;
        }
    }
}
