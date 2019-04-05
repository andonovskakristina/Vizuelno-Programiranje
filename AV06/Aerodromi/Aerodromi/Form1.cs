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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Azuriraj()
        {
            lbDestinacii.Items.Clear();
            tbNajskapaDestinacija.Clear();
            tbProsecnaDolzina.Clear();

            int max;
            decimal prosek = 0;
            Destinacija maxDest;
            if (lbAerodromi.SelectedIndex != -1 && ((Aerodrom)lbAerodromi.SelectedItem).Destinacii.Count != 0)
            {
                max = ((Aerodrom)lbAerodromi.SelectedItem).Destinacii[0].Cena;
                maxDest = ((Aerodrom)lbAerodromi.SelectedItem).Destinacii[0];
                foreach (Destinacija dest in ((Aerodrom)lbAerodromi.SelectedItem).Destinacii)
                {
                    if (max < dest.Cena)
                    {
                        max = dest.Cena;
                        maxDest = dest;
                    }
                    prosek += dest.Oddalecenost;

                    lbDestinacii.Items.Add(dest);
                }

                tbNajskapaDestinacija.Text = maxDest.ToString();
                prosek /= ((Aerodrom)lbAerodromi.SelectedItem).Destinacii.Count;
                tbProsecnaDolzina.Text = prosek.ToString();
            }
        }

        private void btnDodadiAerodrom_Click(object sender, EventArgs e)
        {
            DodadiAerodrom forma = new DodadiAerodrom();
            forma.ShowDialog();

            if(forma.DialogResult == DialogResult.OK)
            {
                lbAerodromi.Items.Add(forma.Aerodrom);
            }
        }

        private void btnIzbrisiAerodrom_Click(object sender, EventArgs e)
        {
            if(lbAerodromi.SelectedIndex != -1)
            {
                if(MessageBox.Show("Дали сте сигурни дека сакате да го избришете избраниот аеродром?", "Избриши аеродром", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    lbAerodromi.Items.Remove(lbAerodromi.SelectedItem);
            }
            else
            {
                MessageBox.Show("Селектирајте го аеродромот што сакате да го избришете!");
            }
        }

        private void btnDodadiDestinacija_Click(object sender, EventArgs e)
        {
            if (lbAerodromi.SelectedIndex != -1)
            {
                DodadiDestinacija forma = new DodadiDestinacija();
                forma.ShowDialog();

                if(forma.DialogResult == DialogResult.OK)
                {
                    ((Aerodrom)lbAerodromi.SelectedItem).Destinacii.Add(forma.Destinacija);
                    Azuriraj();
                }
            }
            else
            {
                MessageBox.Show("Селектирајте го аеродромот за кој сакате да додадете дестинација!");
            }
        }

        private void lbAerodromi_SelectedIndexChanged(object sender, EventArgs e)
        {
            Azuriraj();
        }
    }
}
