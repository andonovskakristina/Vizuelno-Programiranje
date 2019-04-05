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
    public partial class PrintForm : Form
    {
        public List<Ticket> ticketi { get; set; }
        public string dobivka { get; set; }
        public string koeficient { get; set; }
        public string uplata { get; set; }
        public string danok { get; set; }

        public PrintForm()
        {
            InitializeComponent();
        }
        
        public void init()
        {
            lblKoeficient.Text = koeficient;
            lblDanok.Text = danok;
            lblDobivka.Text = dobivka;
            lblUplata.Text = uplata;

            foreach(var tiket in ticketi)
            {
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = tiket.game.Code;
                row.Cells[1].Value = tiket.ToString();
                row.Cells[2].Value = tiket.game.Coefficients[tiket.Tip];
                dataGridView1.Rows.Add(row);
            }
        }
    }
}
