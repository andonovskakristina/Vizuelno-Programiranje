using Pacman.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pacman
{
    public partial class Form1 : Form
    {
        Pacman pacman;
        static readonly int TIMER_INTERVAL = 250;
        static readonly int WORLD_WIDTH = 15;
        static readonly int WORLD_HEIGHT = 10;
        Image foodImage;
        Image img;
        bool[][] foodWorld;
        Timer Timer;
        int Points;
        static int MAX_POINTS = WORLD_WIDTH * WORLD_HEIGHT - 8 * 3;
        List<int> BlackBlocksList;
        public Form1()
        {
            InitializeComponent();
            // Vcituvanje na slika od resursi
            foodImage = Resources.orange2;
            DoubleBuffered = true;
            newGame();
            Points = 0;
            progressBar1.Maximum = MAX_POINTS;
            progressBar1.Value = 0;
            img = Resources.congratulations;
            BlackBlocksList = new List<int>();
            BlackBlocks();
        }

        public void newGame()
        {
            pacman = new Pacman();
            this.Width = Pacman.Radius * 2 * (WORLD_WIDTH + 1);
            this.Height = Pacman.Radius * 2 * (WORLD_HEIGHT + 1) + 70;

            // овде кодот за иницијализација на матрицата foodWorld
            foodWorld = new bool[WORLD_HEIGHT][];
            for(int i = 0; i < WORLD_HEIGHT; i++)
            {
                foodWorld[i] = new bool[WORLD_WIDTH];
            }

            for(int i = 0; i < WORLD_HEIGHT; i++)
            {
                for(int j = 0; j < WORLD_WIDTH; j++)
                {
                    foodWorld[i][j] = true;
                }
            }

            // овде кодот за иницијализација и стартување на тајмерот
            Timer = new Timer();
            Timer.Interval = TIMER_INTERVAL;
            Timer.Tick += new EventHandler(timer_Tick);
            Timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            for(int i = 0; i < WORLD_HEIGHT; i++)
            {
                for(int j = 0; j < WORLD_WIDTH; j++)
                {
                    if(pacman.X == j * Pacman.Radius * 2 + (Pacman.Radius * 2 - foodImage.Height) / 2 && pacman.Y == i * Pacman.Radius * 2 + (Pacman.Radius * 2 - foodImage.Width) / 2 && foodWorld[i][j] == true) {
                        foodWorld[i][j] = false;
                        Points++;
                        lblPoeni.Text = Points.ToString();
                        progressBar1.Value = Points;
                    }
                }
            }

            pacman.Move(WORLD_WIDTH, WORLD_HEIGHT, BlackBlocksList);
            Invalidate();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Up)
            {
                pacman.ChangeDirection(Pacman.DIRECTION.Up);
            }
            else if(e.KeyCode == Keys.Down)
            {
                pacman.ChangeDirection(Pacman.DIRECTION.Down);
            }
            else if (e.KeyCode == Keys.Left)
            {
                pacman.ChangeDirection(Pacman.DIRECTION.Left);
            }
            else if (e.KeyCode == Keys.Right)
            {
                pacman.ChangeDirection(Pacman.DIRECTION.Right);
            }

            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);
            for (int i = 0; i < foodWorld.Length; i++)
            {
                for (int j = 0; j < foodWorld[i].Length; j++)
                {
                    if(BlackBlocksList.Contains(i * foodWorld[i].Length + j))
                    {
                        foodWorld[i][j] = false;
                        g.FillRectangle(new SolidBrush(Color.Black), j * Pacman.Radius * 2 + (Pacman.Radius * 2 - foodImage.Height) / 2, i * Pacman.Radius * 2 + (Pacman.Radius * 2 - foodImage.Width) / 2, 2 * Pacman.Radius, 2 * Pacman.Radius);
                    }
                    else if (foodWorld[i][j])
                    {
                        g.DrawImageUnscaled(foodImage, j * Pacman.Radius * 2 + (Pacman.Radius * 2 - foodImage.Height) / 2, i * Pacman.Radius * 2 + (Pacman.Radius * 2 - foodImage.Width) / 2);
                    }
                }
            }
            pacman.Draw(g);

            if(Points == MAX_POINTS)
            {
                Timer.Stop();
                g.DrawImageUnscaled(img, WORLD_WIDTH * Pacman.Radius / 6, WORLD_HEIGHT * Pacman.Radius / 7);
            } 
        }

        public void BlackBlocks()
        {
            Random PickRandom = new Random();

            // ima vkupno WORLD_WIDTH * WORLD_HEIGHT polinja
            // go cuvam samo najgorniot od blokot, znaci otpagjaat poslednite dva reda
            // vkupno WORLD_WIDTH * (WORLD_HEIGHT - 2) polinja

            // vo niza gi cuvame site mozni polinja
            List<int> PickRandomFromList = new List<int>();
            for(int i = 1; i < WORLD_WIDTH * (WORLD_HEIGHT - 2); i++)
            {
                PickRandomFromList.Add(i);
            }

            int[] PickedElements = new int[8];
            int index = 0;

            while(true)
            {
                if (PickRandomFromList.Count > 0 && index < 8)
                {
                    // uste nemame izbrano tocno 8 polinja
                    // izberi pole od moznite
                    int temp = PickRandom.Next(0, PickRandomFromList.Count);
                    PickedElements[index] = PickRandomFromList[temp];

                    // od listata otstrani go izbraniot element, dvata drugi elementi od blokot(dokolku postojat)
                    PickRandomFromList.Remove(PickedElements[index]);
                    if (PickRandomFromList.Contains(PickedElements[index] + WORLD_WIDTH))
                    {
                        PickRandomFromList.Remove(PickedElements[index] + WORLD_WIDTH);
                    }
                    if (PickRandomFromList.Contains(PickedElements[index] + 2 * WORLD_WIDTH))
                    {
                        PickRandomFromList.Remove(PickedElements[index] + 2 * WORLD_WIDTH);
                    }

                    // otstrani gi elementite levo od blokot, dokolku postojat
                    if (PickRandomFromList.Contains(PickedElements[index] - 1) && PickedElements[index] - 1 % WORLD_WIDTH != 0 && PickedElements[index] != 0)
                    {
                        PickRandomFromList.Remove(PickedElements[index] - 1);
                    }
                    if (PickRandomFromList.Contains(PickedElements[index] - 1 - WORLD_WIDTH) && PickedElements[index] - 1 % WORLD_WIDTH != 0 && PickedElements[index] != 0)
                    {
                        PickRandomFromList.Remove(PickedElements[index] - 1 - WORLD_WIDTH);
                    }
                    if (PickRandomFromList.Contains(PickedElements[index] - 1 - 2 * WORLD_WIDTH) && PickedElements[index] - 1 % WORLD_WIDTH != 0 && PickedElements[index] != 0)
                    {
                        PickRandomFromList.Remove(PickedElements[index] - 1 - 2 * WORLD_WIDTH);
                    }
                    if (PickRandomFromList.Contains(PickedElements[index] + WORLD_WIDTH - 1) && PickedElements[index] - 1 % WORLD_WIDTH != 0 && PickedElements[index] != 0)
                    {
                        PickRandomFromList.Remove(PickedElements[index] + WORLD_WIDTH - 1);
                    }
                    if (PickRandomFromList.Contains(PickedElements[index] + 2 * WORLD_WIDTH - 1) && PickedElements[index] - 1 % WORLD_WIDTH != 0 && PickedElements[index] != 0)
                    {
                        PickRandomFromList.Remove(PickedElements[index] + 2 * WORLD_WIDTH - 1);
                    }

                    // otstrani gi elementite desno od blokot, dokolku postojat
                    if (PickRandomFromList.Contains(PickedElements[index] + 1) && PickedElements[index] % WORLD_WIDTH != WORLD_WIDTH - 1)
                    {
                        PickRandomFromList.Remove(PickedElements[index] + 1);
                    }
                    if (PickRandomFromList.Contains(PickedElements[index] + 1 - WORLD_WIDTH) && PickedElements[index] % WORLD_WIDTH != WORLD_WIDTH - 1)
                    {
                        PickRandomFromList.Remove(PickedElements[index] + 1 - WORLD_WIDTH);
                    }
                    if (PickRandomFromList.Contains(PickedElements[index] + 1 - 2 * WORLD_WIDTH) && PickedElements[index] % WORLD_WIDTH != WORLD_WIDTH - 1)
                    {
                        PickRandomFromList.Remove(PickedElements[index] + 1 - 2 * WORLD_WIDTH);
                    }
                    if (PickRandomFromList.Contains(PickedElements[index] + WORLD_WIDTH + 1) && PickedElements[index] % WORLD_WIDTH != WORLD_WIDTH - 1)
                    {
                        PickRandomFromList.Remove(PickedElements[index] + WORLD_WIDTH + 1);
                    }
                    if (PickRandomFromList.Contains(PickedElements[index] + 2 * WORLD_WIDTH + 1) && PickedElements[index] % WORLD_WIDTH != WORLD_WIDTH - 1)
                    {
                        PickRandomFromList.Remove(PickedElements[index] + 2 * WORLD_WIDTH + 1);
                    }

                    // otstrani go elementot nad blokot i dvata nad nego, dokolku postojat
                    if(PickRandomFromList.Contains(PickedElements[index] - WORLD_WIDTH))
                    {
                        PickRandomFromList.Remove(PickedElements[index] - WORLD_WIDTH);
                    }
                    if (PickRandomFromList.Contains(PickedElements[index] - 2 * WORLD_WIDTH))
                    {
                        PickRandomFromList.Remove(PickedElements[index] - 2 * WORLD_WIDTH);
                    }
                    if (PickRandomFromList.Contains(PickedElements[index] - 3 * WORLD_WIDTH))
                    {
                        PickRandomFromList.Remove(PickedElements[index] - 3 * WORLD_WIDTH);
                    }

                    // otstrani go elementot pod blokot, dokolku postoi
                    if (PickRandomFromList.Contains(PickedElements[index] + 3 * WORLD_WIDTH))
                    {
                        PickRandomFromList.Remove(PickedElements[index] + 3 * WORLD_WIDTH);
                    }

                    index++;

                }
                else if(PickRandomFromList.Count == 0)
                {
                    // od novo
                    PickRandomFromList = new List<int>();
                    for (int i = 0; i < WORLD_WIDTH * (WORLD_HEIGHT - 2); i++)
                    {
                        PickRandomFromList.Add(i);
                    }

                    PickedElements = new int[8];
                    index = 0;
                }
                else
                {
                    foreach (int i in PickedElements)
                    {
                        BlackBlocksList.Add(i);
                        if(i + WORLD_WIDTH < WORLD_WIDTH * WORLD_HEIGHT)
                            BlackBlocksList.Add(i + WORLD_WIDTH);
                        if (i + 2 * WORLD_WIDTH < WORLD_WIDTH * WORLD_HEIGHT)
                            BlackBlocksList.Add(i + 2 * WORLD_WIDTH);
                    }

                    break;
                }
            }
        }
    }
}
