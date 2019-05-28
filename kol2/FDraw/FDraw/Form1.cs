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

namespace FDraw
{
    public partial class Form1 : Form
    {
        public RectanglesDoc doc { get; set; }
        public Color CurrentColor { get; set; }
        public Point FirstPoint { get; set; }
        public Rectangle DottedRectangle { get; set; }
        public bool CtrlPressed { get; set; }
        public string FileName { get; set; }

        public Form1()
        {
            InitializeComponent();
            doc = new RectanglesDoc();
            CurrentColor = Color.Blue;
            FirstPoint = new Point(-1, -1);
            DottedRectangle = null;
            CtrlPressed = false;
            FileName = "Untitled";
            DoubleBuffered = true;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (!doc.IsHit(e.X, e.Y))
            {
                FirstPoint = e.Location;
            }
            Invalidate();
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (DottedRectangle == null)
            {
                doc.RefreshSelected();
            }
            else
            {
                FirstPoint = new Point(-1, -1);
                doc.AddRectangle(DottedRectangle);
                DottedRectangle = null;
            }
            Invalidate();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if(doc.Selected())
            {
                doc.Move(e.X, e.Y);
            }
            else if(FirstPoint != new Point(-1, -1))
            {
                int width = Distance(FirstPoint, new Point(e.X, FirstPoint.Y));
                int height = Distance(FirstPoint, new Point(FirstPoint.X, e.Y));

                if (!CtrlPressed)
                {
                    DottedRectangle = new Rectangle(FirstPoint.X, FirstPoint.Y, width, height, CurrentColor);
                }
                else
                {
                    if(width > height)
                        DottedRectangle = new Rectangle(FirstPoint.X, FirstPoint.Y, width, width, CurrentColor);
                    else
                        DottedRectangle = new Rectangle(FirstPoint.X, FirstPoint.Y, height, height, CurrentColor);
                }
            }

            Invalidate();
        }

        public int Distance(Point p1, Point p2)
        {
            return Convert.ToInt32(Math.Sqrt((p1.X - p2.X) * (p1.X - p2.X) + (p1.Y - p2.Y) * (p1.Y - p2.Y)));
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.ControlKey)
            {
                CtrlPressed = true;
            }

            Invalidate();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.ControlKey)
            {
                CtrlPressed = false;
            }

            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            NumRectangles.Text = "Вкупно: " + doc.Rectangles.Count;

            doc.Draw(e.Graphics);

            if(DottedRectangle != null)
            {
                DottedRectangle.DrawDotted(e.Graphics);
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

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doc = new RectanglesDoc();
            DottedRectangle = null;
            FirstPoint = new Point(-1, -1);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Rectangles doc file (*.rec)|*.rec";
            openFileDialog.Title = "Open Rectangles doc file";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileName = openFileDialog.FileName;
                try
                {
                    using (FileStream fileStream = new FileStream(FileName, FileMode.Open))
                    {
                        IFormatter formater = new BinaryFormatter();
                        doc = (RectanglesDoc)formater.Deserialize(fileStream);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not read file: " + FileName);
                    FileName = null;
                    return;
                }
                Invalidate();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FileName == "Untitled")
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Rectangles doc file (*.rec)|*.rec";
                saveFileDialog.Title = "Save Rectangles doc";
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
