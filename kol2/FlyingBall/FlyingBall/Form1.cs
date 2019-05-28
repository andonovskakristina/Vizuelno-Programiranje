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

namespace FlyingBall
{
    public partial class Form1 : Form
    {
        public BallsDoc doc { get; set; }
        public Random random { get; set; }
        public int CountSeconds { get; set; }
        public string FileName { get; set; }

        public Form1()
        {
            InitializeComponent();
            doc = new BallsDoc();
            random = new Random();
            FileName = "Untitled";
            DoubleBuffered = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CountSeconds++;
            if(CountSeconds % 10 == 0)
            {
                int type = random.Next(0, 3);
                int y = random.Next(2 * Ball.Radius, this.Height - 3 * Ball.Radius);

                doc.AddBall(0, y, type);
            }

            doc.Move();
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            doc.DeleteBalls(this.Width);
            NumHits.Text = "Hits: " + doc.Hits;
            NumMisses.Text = "Misses: " + doc.Misses;

            e.Graphics.Clear(Color.White);
            doc.Draw(e.Graphics);
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            doc.ChangeType(e.X, e.Y);
            Invalidate();
        }

        private void pauseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(pauseToolStripMenuItem.Text == "Pause")
            {
                pauseToolStripMenuItem.Text = "Continue";
                timer1.Stop();
            }
            else
            {
                pauseToolStripMenuItem.Text = "Pause";
                timer1.Start();
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doc = new BallsDoc();
            CountSeconds = 0;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Balls doc file (*.bl)|*.bl";
            openFileDialog.Title = "Open Balls doc file";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileName = openFileDialog.FileName;
                try
                {
                    using (FileStream fileStream = new FileStream(FileName, FileMode.Open))
                    {
                        IFormatter formater = new BinaryFormatter();
                        doc = (BallsDoc)formater.Deserialize(fileStream);
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
                saveFileDialog.Filter = "Balls doc file (*.bl)|*.bl";
                saveFileDialog.Title = "Save balls doc";
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
