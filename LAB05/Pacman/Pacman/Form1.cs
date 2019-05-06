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
        Timer timer;
        Pacman pacman;
        static readonly int TIMER_INTERVAL = 250;
        static readonly int WORLD_WIDTH = 15;
        static readonly int WORLD_HEIGHT = 10;
        Image foodImage;
        bool[][] foodWorld;
        public Form1()
        {
            InitializeComponent();
            // Vcituvanje na slika od resursi
            foodImage = Resources.orange;
            DoubleBuffered = true;
            newGame();
        }

        public void newGame()
        {
            pacman = new Pacman();
            this.Width = Pacman.Radius * 2 * (WORLD_WIDTH + 1);
            this.Height = Pacman.Radius * 2 * (WORLD_HEIGHT + 1);

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
            Timer Timer = new Timer();
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
                    if(pacman.X == j * Pacman.Radius * 2 + (Pacman.Radius * 2 - foodImage.Height) / 2 && pacman.Y == i * Pacman.Radius * 2 + (Pacman.Radius * 2 - foodImage.Width) / 2) {
                        foodWorld[i][j] = false;
                    }
                }
            }

            pacman.Move(WORLD_WIDTH, WORLD_HEIGHT);
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
                    if (foodWorld[i][j])
                    {
                        g.DrawImageUnscaled(foodImage, j * Pacman.Radius * 2 + (Pacman.Radius * 2 - foodImage.Height) / 2, i * Pacman.Radius * 2 + (Pacman.Radius * 2 - foodImage.Width) / 2);
                    }
                }
            }
            pacman.Draw(g);
        }
    }
}
