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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDodadiTim_Click(object sender, EventArgs e)
        {
            TeamForm teamForm = new TeamForm();
            DialogResult result = teamForm.ShowDialog();
            if(result == DialogResult.OK)
            {
                lbTimovi.Items.Add(teamForm.Team);
            }
        }

        private void btnDodadiVoBilten_Click(object sender, EventArgs e)
        {
            if(lbTimovi.SelectedItems.Count != 2)
            {
                MessageBox.Show("Одберете точно два тима!");
            }
            else
            {
                Game game = new Game();
                game.Home = (Team)lbTimovi.SelectedItems[0];
                game.Guest = (Team)lbTimovi.SelectedItems[1];
                game.Coefficients[0] = nud1.Value;
                game.Coefficients[1] = nudX.Value;
                game.Coefficients[2] = nud2.Value;
                game.Code = mtbSifra1.Text;

                lbNatprevari.Items.Add(game);
                lbTimovi.SelectedItems.Clear();
            }
        }

        void recalculateCoefficients()
        {
            decimal totalCoeff = 1;
            foreach(Ticket t in lbKarti.Items)
            {
                Game game = t.game;
                decimal localCoeff = game.Coefficients[t.Tip];
                totalCoeff *= localCoeff;
            }

            tbVkupnoKoeficient.Text = totalCoeff.ToString(".00");
            tbDobivka.Text = (nudUplata.Value * totalCoeff).ToString("0.00");
        }

        private void btnDodadiNatprevar_Click(object sender, EventArgs e)
        {
            if(cbTip.SelectedIndex == -1)
            {
                MessageBox.Show("Изберете тип!");
                return;
            }

            if(mtbSifra2.Text != "")
            {
                foreach(Game game in lbNatprevari.Items)
                {
                    if(game.Code == mtbSifra2.Text)
                    {
                        Ticket ticket = new Ticket();
                        ticket.game = game;
                        ticket.Tip = cbTip.SelectedIndex;

                        lbKarti.Items.Add(ticket);

                        recalculateCoefficients();
                        return;
                    }
                }

                MessageBox.Show("Внесете валидна шифра!");
            }
            else if(lbNatprevari.SelectedIndex != -1)
            {
                Ticket ticket = new Ticket();
                ticket.game = (Game)lbNatprevari.SelectedItem;
                ticket.Tip = cbTip.SelectedIndex;

                lbKarti.Items.Add(ticket);
                lbNatprevari.SelectedItems.Clear();
                recalculateCoefficients();
            }
            else
            {
                MessageBox.Show("Внесете шифра или изберете натпревар од листата!");
            }
        }

        private void nudUplata_ValueChanged(object sender, EventArgs e)
        {
            recalculateCoefficients();
        }

        private void btnPecati_Click(object sender, EventArgs e)
        {
            try
            {
                PrintForm form = new PrintForm();
                List<Ticket> tiketi = new List<Ticket>();

                foreach(var item in lbKarti.Items)
                {
                    tiketi.Add((Ticket) item);
                }

                form.ticketi = tiketi;
                form.dobivka = tbDobivka.Text;
                form.koeficient = tbVkupnoKoeficient.Text;
                form.uplata = nudUplata.Value.ToString();
                form.danok = ((decimal.Parse(tbDobivka.Text)) * 0.10m).ToString(".00");
                form.init();
                form.ShowDialog();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Нема натпревари!");
            }
        }
    }
}
