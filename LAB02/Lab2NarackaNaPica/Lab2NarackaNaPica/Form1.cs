using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2NarackaNaPica
{
    public partial class Form1 : Form
    {
        public void calculateTotal()
        {
            // ... vasiot kod ovde ...
            int sum = 0;
            int parse = 0;

            // golemina
            if (rbMala.Checked)
            {
                int.TryParse(tbMala.Text, out parse);
                sum += parse;
            }
            else if(rbSredna.Checked)
            {
                int.TryParse(tbSredna.Text, out parse);
                sum += parse;
            }
            else if (rbGolema.Checked)
            {
                int.TryParse(tbGolema.Text, out parse);
                sum += parse;
            }

            // dodatoci
            if(cbFeferonki.Checked)
            {
                parse = 0;
                int.TryParse(tbFeferonki.Text, out parse);
                sum += parse;
            }
            if (cbEkstraSirenje.Checked)
            {
                parse = 0;
                int.TryParse(tbEkstraSirenje.Text, out parse);
                sum += parse;
            }
            if (cbKechap.Checked)
            {
                parse = 0;
                int.TryParse(tbKechap.Text, out parse);
                sum += parse;
            }

            // pijalok
            parse = 0;
            int.TryParse(tbVkupnoKokaKola.Text, out parse);
            sum += parse;
            parse = 0;
            int.TryParse(tbVkupnoSokJabolko.Text, out parse);
            sum += parse;
            parse = 0;
            int.TryParse(tbVkupnoPivo.Text, out parse);
            sum += parse;

            // desert
            parse = 0;
            int.TryParse(tbCenaDesert.Text, out parse);
            sum += parse;

            tbVkupnoZaPlakjanje.Text = Convert.ToString(sum);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void lbDeserti_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbDeserti.SelectedItem == "Овошна пита")
                tbCenaDesert.Text = "80";
            if (lbDeserti.SelectedItem == "Сладолед")
                tbCenaDesert.Text = "120";
            if (lbDeserti.SelectedItem == "Торта")
                tbCenaDesert.Text = "160";

            calculateTotal();
        }

        private void rbMala_CheckedChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }
        
        private void rbSredna_CheckedChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void rbGolema_CheckedChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void tbKokaKola_TextChanged(object sender, EventArgs e)
        {
            int parse = 0;
            int.TryParse(tbKokaKola.Text, out parse);

            int parseCena = 0;
            int.TryParse(tbCenaKokaKola.Text, out parseCena);

            tbVkupnoKokaKola.Text = Convert.ToString(parse * parseCena);

            calculateTotal();
        }

        private void tbSokJabolko_TextChanged(object sender, EventArgs e)
        {
            int parse = 0;
            int.TryParse(tbSokJabolko.Text, out parse);

            int parseCena = 0;
            int.TryParse(tbCenaSokJabolko.Text, out parseCena);

            tbVkupnoSokJabolko.Text = Convert.ToString(parse * parseCena);

            calculateTotal();
        }

        private void tbPivo_TextChanged(object sender, EventArgs e)
        {
            int parse = 0;
            int.TryParse(tbPivo.Text, out parse);

            int parseCena = 0;
            int.TryParse(tbCenaPivo.Text, out parseCena);

            tbVkupnoPivo.Text = Convert.ToString(parse * parseCena);

            calculateTotal();
        }

        private void cbFeferonki_CheckedChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void cbEkstraSirenje_CheckedChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void cbKechap_CheckedChanged(object sender, EventArgs e)
        {
            calculateTotal();
        }

        private void btnOtkazi_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Дали сакате да ја откажете нарачката?", "Откажи нарачка",
                MessageBoxButtons.YesNo, // vid na dijalogot 
                MessageBoxIcon.Question); // ikona na dijalogot
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnNaracaj_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            if (rbMala.Checked)
                sb.Append("Мала пица");
            else if (rbSredna.Checked)
                sb.Append("Средна пица");
            else if (rbGolema.Checked)
                sb.Append("Голема пица");

            sb.AppendLine();
            if (tbKokaKola.Text != "0" || tbSokJabolko.Text != "0" || tbPivo.Text != "0")
            { 
                sb.Append("Пијалок:");
                sb.AppendLine();
            }

            if (tbKokaKola.Text != "0")
            {
                sb.Append(tbKokaKola.Text + " Кока кола / Фанта / Спрајт\n");
            }
            if (tbSokJabolko.Text != "0")
            {
                sb.Append(tbSokJabolko.Text + " Сок од јаболко / портокал\n");
            }
            if (tbPivo.Text != "0")
            {
                sb.Append(tbPivo.Text + " Пиво\n");
            }
            
            if (lbDeserti.SelectedIndex != -1)
            {
                sb.Append("Десерт:\n");
                sb.Append(lbDeserti.SelectedItem.ToString());
            }

            DialogResult result = MessageBox.Show(sb.ToString(), "Вашата нарачка",
                MessageBoxButtons.OK, // vid na dijalogot 
                MessageBoxIcon.None); // ikona na dijalogot
        }

        private void tbNaplateno_TextChanged(object sender, EventArgs e)
        {
            int parse = 0;
            int.TryParse(tbNaplateno.Text, out parse);

            int parseVkupno = 0;
            int.TryParse(tbVkupnoZaPlakjanje.Text, out parseVkupno);

            tbZaVrakjanje.Text = Convert.ToString(parse - parseVkupno);
        }

    }
}
