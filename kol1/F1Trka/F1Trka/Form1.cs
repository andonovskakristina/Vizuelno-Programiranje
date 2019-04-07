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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void AzurirajKrugovi()
        {
            lbKrugovi.Items.Clear();
            tbNajdobarKrug.Clear();
            Krug NajdobarKrug = new Krug();
            int vreme;

            if(lbVozaci.SelectedIndex != -1 && ((Vozac)lbVozaci.SelectedItem).Krugovi.Count != 0)
            {
                NajdobarKrug = ((Vozac)lbVozaci.SelectedItem).Krugovi[0];
                vreme = ((Vozac)lbVozaci.SelectedItem).Krugovi[0].Minuti * 60 + ((Vozac)lbVozaci.SelectedItem).Krugovi[0].Sekundi;
                foreach (Krug Krug in ((Vozac)lbVozaci.SelectedItem).Krugovi)
                {
                    if (Krug.Minuti * 60 + Krug.Sekundi >= (int)nudVreme.Value)
                    {
                        lbKrugovi.Items.Add(Krug);

                        if (vreme > Krug.Minuti * 60 + Krug.Sekundi)
                        {
                            vreme = Krug.Minuti * 60 + Krug.Sekundi;
                            NajdobarKrug = Krug;
                        }
                    }
                }

                tbNajdobarKrug.Text = NajdobarKrug.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lbVozaci_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbVozaci.SelectedIndex != -1)
            {
                btnIzbrisiVozac.Enabled = true;
                btnDodadiKrug.Enabled = true;
                AzurirajKrugovi();
            }
            else
            {
                btnIzbrisiVozac.Enabled = false;
                btnDodadiKrug.Enabled = false;
            }
        }

        private void btnDodadiVozac_Click(object sender, EventArgs e)
        {
            DodadiVozac forma = new DodadiVozac();
            forma.ShowDialog();

            if(forma.DialogResult == DialogResult.OK)
            {
                lbVozaci.Items.Add(forma.Vozac);
                lbVozaci.SelectedItem = forma.Vozac;
                AzurirajKrugovi();
            }
        }

        private void btnIzbrisiVozac_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Дали сте сигурни дека сакате да го избришете селектираниот возач?", "Избриши возач", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                lbVozaci.Items.Remove(lbVozaci.SelectedItem);
                AzurirajKrugovi();
            }
        }

        private void btnDodadiKrug_Click(object sender, EventArgs e)
        {
            Krug Krug = new Krug();
            Krug.Minuti = (int)nudMinuti.Value;
            Krug.Sekundi = (int)nudSekundi.Value;
            ((Vozac)lbVozaci.SelectedItem).Krugovi.Add(Krug);

            AzurirajKrugovi();
        }

        private void nudVreme_ValueChanged(object sender, EventArgs e)
        {
            AzurirajKrugovi();
        }
    }
}
