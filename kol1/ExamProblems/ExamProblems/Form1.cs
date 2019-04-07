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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Azuriraj()
        {
            tbOpis1.Clear();
            tbOpis2.Clear();
            nudPoeni1.Value = 0;
            nudPoeni2.Value = 0;

            if(lbIspiti.SelectedIndex != -1)
            {
                if(((Ispit)lbIspiti.SelectedItem).Zadaca1 != null)
                {
                    tbOpis1.Text = ((Ispit)lbIspiti.SelectedItem).Zadaca1.Opis;
                    nudPoeni1.Value = ((Ispit)lbIspiti.SelectedItem).Zadaca1.Poeni;
                }

                if (((Ispit)lbIspiti.SelectedItem).Zadaca2 != null)
                {
                    tbOpis2.Text = ((Ispit)lbIspiti.SelectedItem).Zadaca2.Opis;
                    nudPoeni2.Value = ((Ispit)lbIspiti.SelectedItem).Zadaca2.Poeni;
                }
            }
        }

        private void btnDodadiIspit_Click(object sender, EventArgs e)
        {
            DodadiIspit forma = new DodadiIspit();
            forma.ShowDialog();

            if(forma.DialogResult == DialogResult.OK)
            {
                lbIspiti.Items.Add(forma.Ispit);
                Azuriraj();
            }
        }

        private void btnIzbrisiIspit_Click(object sender, EventArgs e)
        {
            lbIspiti.Items.Remove(lbIspiti.SelectedItem);
            Azuriraj();
        }

        private void lbIspiti_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbIspiti.SelectedIndex != -1)
            {
                btnIzbrisiIspit.Enabled = true;
            }
            else
            {
                btnIzbrisiIspit.Enabled = false;
            }

            Azuriraj();
        }

        private void btnZacuvaj1_Click(object sender, EventArgs e)
        {
            if(lbIspiti.SelectedIndex != -1)
            {
                ((Ispit)lbIspiti.SelectedItem).Zadaca1.Opis = tbOpis1.Text;
                ((Ispit)lbIspiti.SelectedItem).Zadaca1.Poeni = (int)nudPoeni1.Value;
                MessageBox.Show("Зачувано!");
            }
            else
            {
                MessageBox.Show("Изберете испит!");
            }
        }

        private void btnZacuvaj2_Click(object sender, EventArgs e)
        {
            if (lbIspiti.SelectedIndex != -1)
            {
                ((Ispit)lbIspiti.SelectedItem).Zadaca2.Opis = tbOpis2.Text;
                ((Ispit)lbIspiti.SelectedItem).Zadaca2.Poeni = (int)nudPoeni2.Value;
                MessageBox.Show("Зачувано!");
            }
            else
            {
                MessageBox.Show("Изберете испит!");
            }
        }
    }
}
