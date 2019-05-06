using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Circles
{
    public partial class Form1 : Form
    {
        Graphics graphics;
        Brush brush;
        Color color;
        int radius;
        public Form1()
        {
            InitializeComponent();
            graphics = panel1.CreateGraphics();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            color = p.BackColor;
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            brush = new SolidBrush(color);
            radius = (int)nudGolemina.Value;
            graphics.FillEllipse(brush, e.X - radius, e.Y - radius, 2 * radius, 2 * radius);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            MessageBox.Show("Hi!");
        }
    }
}
