using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamProblems
{
    public partial class DodadiIspit : Form
    {
        public Ispit Ispit;
        public DodadiIspit()
        {
            InitializeComponent();
        }

        private void cbMesec_Validating(object sender, CancelEventArgs e)
        {
            if(cbMesec.SelectedIndex == -1)
            {
                errorProvider1.SetError(cbMesec, "Задолжително изберете месец!");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(cbMesec, null);
                e.Cancel = false;
            }
        }

        private void btnDodadi_Click(object sender, EventArgs e)
        {
            Ispit = new Ispit();
            Ispit.Godina = (int)nudGodina.Value;
            Ispit.Mesec = cbMesec.Text;

            DialogResult = DialogResult.OK;
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void DodadiIspit_Load(object sender, EventArgs e)
        {
            nudGodina.Value = 2014;
        }
    }
}
