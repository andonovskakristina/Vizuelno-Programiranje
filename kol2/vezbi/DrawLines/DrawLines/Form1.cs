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

namespace DrawLines
{
    public partial class Form1 : Form
    {
        LinesDoc doc;
        Point PrevPoint;
        Point CurrentPoint;
        Color Color;
        int Thickness;
        bool Positioner;
        int X;
        int Y;
        string FileName;
        public Form1()
        {
            InitializeComponent();
            doc = new LinesDoc();
            PrevPoint = new Point(-1, -1);
            CurrentPoint = new Point(-1, -1);
            Color = Color.Black;
            Thickness = 2;
            DoubleBuffered = true;
            Positioner = true;
            X = -1;
            Y = -1;
            FileName = "Untitled";
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            PrevPoint = CurrentPoint;
            CurrentPoint = e.Location;
            if(PrevPoint != new Point(-1, -1))
            {
                Line line = new Line(PrevPoint, CurrentPoint, Color, Thickness);
                doc.Lines.Add(line);
                Invalidate();
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            doc.Draw(e.Graphics);

            if(Positioner)
            {
                Pen pen = new Pen(Color.Gray, 1);
                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                e.Graphics.DrawLine(pen, new Point(0, Y), new Point(Width, Y));
                e.Graphics.DrawLine(pen, new Point(X, 0), new Point(X, Height));
                pen.Dispose();
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            X = e.X;
            Y = e.Y;
            Invalidate();
        }

        private void pickAColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                Color = colorDialog.Color;
            }
        }

        private void thinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thinToolStripMenuItem.Checked = !thinToolStripMenuItem.Checked;
            mediumToolStripMenuItem.Checked = false;
            thickToolStripMenuItem.Checked = false;

            Thickness = 2;
        }

        private void mediumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mediumToolStripMenuItem.Checked = !mediumToolStripMenuItem.Checked;
            thinToolStripMenuItem.Checked = false;
            thickToolStripMenuItem.Checked = false;

            Thickness = 4;
        }

        private void thickToolStripMenuItem_Click(object sender, EventArgs e)
        {
            thickToolStripMenuItem.Checked = !thickToolStripMenuItem.Checked;
            mediumToolStripMenuItem.Checked = false;
            thinToolStripMenuItem.Checked = false;

            Thickness = 6;
        }

        private void positionerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            positionerToolStripMenuItem.Checked = !positionerToolStripMenuItem.Checked;
            Positioner = !Positioner;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FileName == "Untitled")
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Lines doc file (*.lin)|*.lin";
                saveFileDialog.Title = "Save lines doc";
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

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Lines doc file (*.lin)|*.lin";
            openFileDialog.Title = "Open lines doc file";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileName = openFileDialog.FileName;
                try
                {
                    using (FileStream fileStream = new FileStream(FileName, FileMode.Open))
                    {
                        IFormatter formater = new BinaryFormatter();
                        doc = (LinesDoc)formater.Deserialize(fileStream);
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

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doc = new LinesDoc();
            PrevPoint = new Point(-1, -1);
            CurrentPoint = new Point(-1, -1);
            FileName = "Untitled";
        }
    }
}
