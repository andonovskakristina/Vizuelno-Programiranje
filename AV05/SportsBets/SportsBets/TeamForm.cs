using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportsBets
{
    public partial class TeamForm : Form
    {
        public Team Team { get; set; }

        public TeamForm()
        {
            InitializeComponent();
        }

        private void btnDodadi_Click(object sender, EventArgs e)
        {
            Form1 f = Parent as Form1;
            Team = new Team();
            Team.Name = tbImeTim.Text;
            Team.Country = tbDrzava.Text;
            DialogResult = DialogResult.OK;
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
