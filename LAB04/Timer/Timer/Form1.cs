using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        List<Igrac> Igraci;
        Igrac Igrac;
        Equation Equation;

        static readonly int Vreme = 60;
        int IzminatoVreme;

        static readonly int MaxPoeni = 100;

        public Form1()
        {
            InitializeComponent();
            Igraci = new List<Igrac>();
            
            pbPoeni.Maximum = MaxPoeni;
            pbVreme.Maximum = Vreme;
            
            NovaIgra();
        }
        
        public void NovaIgra()
        {
            tbIgrac.Text = "";
            tbOperand1.Text = "";
            tbOperand2.Text = "";
            tbOperator.Text = "";
            tbRezultat.Text = "";

            Igrac = new Igrac();
            tbIgrac.Focus();
            Igrac.Poeni = 0;

            tbRezultat.Enabled = true;

            Equation = new Equation();
            tbOperand1.Text = Equation.Operand1.ToString();
            tbOperand2.Text = Equation.Operand2.ToString();
            tbOperator.Text = Equation.Operator.ToString();

            IzminatoVreme = 0;
            pbPoeni.Value = 0;
            pbVreme.Value = IzminatoVreme;
            AzurirajVreme();
            //timer1.Start();
        }

        public void NovIzraz()
        {
            Equation = new Equation();
            tbOperand1.Text = Equation.Operand1.ToString();
            tbOperand2.Text = Equation.Operand2.ToString();
            tbOperator.Text = Equation.Operator.ToString();
            tbRezultat.Text = "";
        }

        private void tbIgrac_Leave(object sender, EventArgs e)
        {
            timer1.Stop();
            
            if (!string.IsNullOrWhiteSpace(tbIgrac.Text))
            {
                Igrac.Ime = tbIgrac.Text;
            }
            else
            {
                MessageBox.Show("Внесете го вашето име!");
                tbIgrac.Focus();
            }
            
            timer1.Start();
        }

        private void btnPogodi_Click(object sender, EventArgs e)
        {
            if(int.TryParse(tbRezultat.Text, out int res) && res == Equation.Rezultat)
            {
                Igrac.Poeni++;
                pbPoeni.Value = Igrac.Poeni;
                lblPoeni.Text = Igrac.Poeni.ToString();

                // na sekoj 10ti poen dodadi 10 sekundi
                if(Igrac.Poeni % 10 == 0 && IzminatoVreme >= 10)
                {
                    IzminatoVreme -= 10;
                }
                else if(Igrac.Poeni % 10 == 0)
                {
                    IzminatoVreme = 0;
                }

                NovIzraz();
            }
            else
            {
                tbRezultat.Text = "";
            }
        }

        private void btnNovaIgra_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            if (MessageBox.Show("Дали сакате да започнете нова игра?", "Нова игра", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DodadiIgrac();
                NovaIgra();
            }
            else
                timer1.Start();
        }

        private void btnIskluci_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNajdobriIgraci_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Igraci = Igraci.OrderByDescending(x => x.Poeni).ToList();

            StringBuilder sb = new StringBuilder();
            sb.Append("Најдобри играчи:\n");
            int i = 1;
            foreach(Igrac igrac in Igraci)
            {
                sb.Append(i + ". " + igrac.Ime + " - " + igrac.Poeni + "\n");
                i++;
            }

            MessageBox.Show(sb.ToString());
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            IzminatoVreme++;
            pbVreme.Value = Vreme - IzminatoVreme;

            if(Vreme == IzminatoVreme)
            {
                tbRezultat.Enabled = false;
                timer1.Stop();
                MessageBox.Show(string.Format("Вашето време истече! Освоивте {0} поени.", Igrac.Poeni));

                DodadiIgrac();
            }

            AzurirajVreme();
        }

        private void AzurirajVreme()
        {
            int preostanato = Vreme - IzminatoVreme;
            int min = preostanato / 60;
            int sek = preostanato % 60;
            lblVreme.Text = string.Format("{0:00}:{1:00}", min, sek);
        }

        private void DodadiIgrac()
        {
            bool Postoi = false;

            foreach (Igrac igrac in Igraci)
            {
                if (igrac.Ime == Igrac.Ime)
                {
                    if (igrac.Poeni < Igrac.Poeni)
                    {
                        igrac.Poeni = Igrac.Poeni;
                    }
                    Postoi = true;
                    break;
                }
            }

            if (!Postoi)
            {
                Igraci.Add(Igrac);
            }
        }
    }
}
