using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovingObject
{
    public partial class Form1 : Form
    {
        int Radius;
        bool mouseDown;
        Color Color;
        List<Circle> Circles;
        Circle movingCircle;

        public Form1()
        {
            InitializeComponent();
            mouseDown = false;
            Color = Color.Yellow;
            Radius = (int)nudRadius.Value;
            Circles = new List<Circle>();
            DoubleBuffered = true;
            timer1.Start();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if(mouseDown)
            {
                movingCircle.Move(e.X, e.Y);
                Invalidate();
                List<Circle> Temp = new List<Circle>();
                foreach(Circle circle in Circles)
                {
                    if(circle.Equals(movingCircle) || !circle.IsHit(movingCircle))
                    {
                        Temp.Add(circle);
                    }
                }
                Circles = Temp;
                Invalidate();
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            foreach(Circle circle in Circles)
            {
                if (circle.IsHit(e.X, e.Y))
                {
                    mouseDown = true;
                    movingCircle = circle;
                }
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void btnBoja_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                Color = colorDialog.Color;
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            foreach (Circle circle in Circles)
            {
                circle.Draw(e.Graphics);
            }
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Circle circle = new Circle(e.X, e.Y, Radius, Color);
            Circles.Add(circle);
            Invalidate();
        }

        private void nudRadius_ValueChanged(object sender, EventArgs e)
        {
            Radius = (int)nudRadius.Value;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach(Circle circle in Circles)
            {
                circle.Growing();
            }

            Invalidate();
        }
    }
}
