using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacman
{
    public class Pacman
    {
        public int X { get; set; }
        public int Y { get; set; }

        public enum DIRECTION
        {
            Up,
            Down,
            Left,
            Right
        }

        public DIRECTION Direction { get; set; }
        public static int Radius = 20;
        public int Speed { get; set; }
        public bool MouthOpened { get; set; }
        public static Brush Brush = new SolidBrush(Color.Yellow);

        public Pacman()
        {
            X = 0;
            Y = 0;
            Speed = Radius;
            Direction = DIRECTION.Right;
        }

        public void ChangeDirection(DIRECTION direction)
        {
            Direction = direction;
        }

        public void Move(int MAX_X, int MAX_Y, List<int> BlackBlocksList)
        {
            int Width = MAX_X;

            MAX_X = (MAX_X - 1) * Radius * 2;
            MAX_Y = (MAX_Y - 1) * Radius * 2;

            int New_X = X;
            int New_Y = Y;

            if(Direction == DIRECTION.Up)
            {
                if (Y > 0)
                    New_Y -= Radius * 2;
                else
                    New_Y = MAX_Y;
            } 
            else if(Direction == DIRECTION.Down)
            {
                if (Y < MAX_Y)
                    New_Y += Radius * 2;
                else
                    New_Y = 0;
            }
            else if(Direction == DIRECTION.Left)
            {
                if (X > 0)
                    New_X -= Radius * 2;
                else
                    New_X = MAX_X;
            }
            else if(Direction == DIRECTION.Right)
            {
                if (X < MAX_X)
                    New_X += Radius * 2;
                else
                    New_X = 0;
            }

            if ((New_X == 0 && New_Y == 0 && !BlackBlocksList.Contains(0)) || ((New_X != 0 || New_Y != 0) && !BlackBlocksList.Contains((New_Y * Width + New_X) / (2 * Radius))))
            {
                X = New_X;
                Y = New_Y;
                MouthOpened = !MouthOpened;
            }
            else
            {
                MouthOpened = false;
            }
        }

        public void Draw(Graphics g)
        {
            if(MouthOpened)
            {
                if(Direction == DIRECTION.Up)
                {
                    g.FillPie(Brush, X, Y, Radius * 2, Radius * 2, 315, 270);
                }
                else if(Direction == DIRECTION.Down)
                {
                    g.FillPie(Brush, X, Y, Radius * 2, Radius * 2, 135, 270);
                }
                else if(Direction == DIRECTION.Left)
                {
                    g.FillPie(Brush, X, Y, Radius * 2, Radius * 2, 225, 270);
                }
                else if(Direction == DIRECTION.Right)
                {
                    g.FillPie(Brush, X, Y, Radius * 2, Radius * 2, 45, 270);
                }
            }
            else
            {
                g.FillEllipse(Brush, X, Y, Radius * 2, Radius * 2);
            }
        }
    }
}
