using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avtomobili
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Azuriraj()
        {
            tbProsecnaPotrosuvacka.Clear();
            tbNajekonomicen.Clear();
            tbNajskap.Clear();

            int Najskap;
            int Najekonomicen;
            decimal Prosek = 0;
            Avtomobil NajskapA;
            Avtomobil NajekonomicenA;

            if(lbAvtomobili.Items.Count != 0)
            {
                Najskap = ((Avtomobil)lbAvtomobili.Items[0]).Cena;
                Najekonomicen = ((Avtomobil)lbAvtomobili.Items[0]).Potrosuvacka;
                NajskapA = ((Avtomobil)lbAvtomobili.Items[0]);
                NajekonomicenA = ((Avtomobil)lbAvtomobili.Items[0]);

                foreach (Avtomobil Avtomobil in lbAvtomobili.Items)
                {
                    if(Najskap < Avtomobil.Cena)
                    {
                        Najskap = Avtomobil.Cena;
                        NajskapA = Avtomobil;
                    }

                    if(Najekonomicen > Avtomobil.Potrosuvacka)
                    {
                        Najekonomicen = Avtomobil.Potrosuvacka;
                        NajekonomicenA = Avtomobil;
                    }

                    Prosek += Avtomobil.Potrosuvacka;
                }

                tbNajekonomicen.Text = NajekonomicenA.ToString();
                tbNajskap.Text = NajskapA.ToString();
                Prosek /= lbAvtomobili.Items.Count;
                tbProsecnaPotrosuvacka.Text = string.Format("{0:0.00}", Prosek);
            }
        }
        
        private void btnDodadiMarka_Click(object sender, EventArgs e)
        {
            DodadiMarka forma = new DodadiMarka();
            forma.ShowDialog();

            if (forma.DialogResult == DialogResult.OK)
            {
                lbMarki.Items.Add(forma.Marka);
                cbMarka.Items.Add(forma.Marka);
            }
        }

        private void btnDodadiAvtomobil_Click(object sender, EventArgs e)
        {
            if(cbMarka.SelectedIndex != -1)
            {
                if(!string.IsNullOrEmpty(tbModel.Text))
                {
                    Avtomobil Avtomobil = new Avtomobil();
                    Avtomobil.Marka = (Marka)cbMarka.SelectedItem;
                    Avtomobil.Model = tbModel.Text;
                    Avtomobil.Potrosuvacka = (int)nudPotrosuvacka.Value;
                    Avtomobil.Cena = (int)nudCena.Value;

                    lbAvtomobili.Items.Add(Avtomobil);
                    Azuriraj();

                    tbModel.Clear();
                    cbMarka.SelectedIndex = -1;
                    nudCena.Value = 0;
                    nudPotrosuvacka.Value = 0;
                }
                else
                {
                    MessageBox.Show("Внесете модел на автомобил!");
                }
            }
            else
            {
                MessageBox.Show("Изберете марка на автомобил!");
            }
        }

        private void btnIzbrisiAvtomobil_Click(object sender, EventArgs e)
        {
            if(lbAvtomobili.SelectedIndex != -1)
            {
                lbAvtomobili.Items.Remove(lbAvtomobili.SelectedItem);
                Azuriraj();
            }
            else
            {
                MessageBox.Show("Селектирајте го автомобилот што сакате да го избришете од листата!");
            }
        }
    }
}
