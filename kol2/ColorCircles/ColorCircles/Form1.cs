using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorCircles
{
    public partial class Form1 : Form
    {
        public CirclesDoc doc { get; set; }
        public Point FirstPoint { get; set; }
        public Color CurrentColor { get; set; }
        public Circle DottedCircle { get; set; }
        public string FileName { get; set; }

        public Form1()
        {
            InitializeComponent();
            doc = new CirclesDoc();
            FirstPoint = new Point(-1, -1);
            CurrentColor = Color.Green;
            DottedCircle = null;
            FileName = "Untitled";
            DoubleBuffered = true;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (FirstPoint == new Point(-1, -1))
                {
                    FirstPoint = e.Location;
                }
                else
                {
                    int radius = Convert.ToInt32(Math.Sqrt((FirstPoint.X - e.X) * (FirstPoint.X - e.X) + (FirstPoint.Y - e.Y) * (FirstPoint.Y - e.Y)));
                    Circle circle = new Circle(FirstPoint.X, FirstPoint.Y, radius, CurrentColor);
                    doc.AddCircle(circle);
                    FirstPoint = new Point(-1, -1);
                    DottedCircle = null;
                }
            }
            else if(e.Button == MouseButtons.Right)
            {
                doc.Select(e.X, e.Y);
            }

            Invalidate();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if(FirstPoint != new Point(-1, -1))
            {
                int radius = Convert.ToInt32(Math.Sqrt((FirstPoint.X - e.X) * (FirstPoint.X - e.X) + (FirstPoint.Y - e.Y) * (FirstPoint.Y - e.Y)));
                DottedCircle = new Circle(FirstPoint.X, FirstPoint.Y, radius, CurrentColor);

                Invalidate();
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            NumCircles.Text = "Вкупно: " + doc.Circles.Count;

            doc.Draw(e.Graphics);

            if(DottedCircle != null)
            {
                DottedCircle.DrawDotted(e.Graphics);
            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                CurrentColor = colorDialog.Color;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                FirstPoint = new Point(-1, -1);
                DottedCircle = null;
            }

            if(e.KeyCode == Keys.Delete)
            {
                doc.DeleteSelected();
            } 

            Invalidate();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doc = new CirclesDoc();
            FirstPoint = new Point(-1, -1);
            DottedCircle = null;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Circles doc file (*.cir)|*.cir";
            openFileDialog.Title = "Open Circles doc file";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileName = openFileDialog.FileName;
                try
                {
                    using (FileStream fileStream = new FileStream(FileName, FileMode.Open))
                    {
                        IFormatter formater = new BinaryFormatter();
                        doc = (CirclesDoc)formater.Deserialize(fileStream);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not read file: " + FileName);
                    FileName = null;
                    return;
                }
                Invalidate(true);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FileName == "Untitled")
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Circles doc file (*.cir)|*.cir";
                saveFileDialog.Title = "Save circles doc";
                saveFileDialog.FileName = FileName;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileName = saveFileDialog.FileName;
                }
            }
            if (FileName != null)
            {
                using (FileStream fileStream = new FileStream(FileName, FileMode.Create))
                {
                    IFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(fileStream, doc);
                }
            }
        }
    }
}
