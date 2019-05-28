using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyingBall
{
    [Serializable]
    public class BallsDoc
    {
        public List<Ball> Balls { get; set; }
        public int Hits { get; set; }
        public int Misses { get; set; }

        public BallsDoc()
        {
            Balls = new List<Ball>();
            Hits = 0;
            Misses = 0;
        }

        public void AddBall(int x, int y, int type)
        {
            Balls.Add(new Ball(x, y, type));
        }

        public void DeleteBalls(int width)
        {
            for(int i = 0; i < Balls.Count; i++)
            {
                if(Balls[i].Color == Color.White)
                {
                    Balls.RemoveAt(i);
                    i--;
                    Hits++;
                }
                else if(Balls[i].X > width)
                {
                    Balls.RemoveAt(i);
                    i--;
                    Misses++;
                }
            }
        }

        public void Move()
        {
            foreach(Ball ball in Balls)
            {
                ball.Move();
            }
        }

        public void ChangeType(int x, int y)
        {
            foreach(Ball ball in Balls)
            {
                if (ball.IsHit(x, y))
                    ball.ChangeType();
            }
        }

        public void Draw(Graphics g)
        {
            foreach(Ball ball in Balls)
            {
                ball.Draw(g);
            }
        }
    }
}
