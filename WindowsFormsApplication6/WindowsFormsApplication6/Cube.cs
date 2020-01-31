using System;
using System.Drawing;
using System.Windows.Forms;
using static WindowsFormsApplication6.Form1;

namespace WindowsFormsApplication6
{
    
    public class Cube
    {
        private PictureBox ball;
       public int ySpeed, xSpeed;
        
       
        Random rnd = new Random();
        public int leftscore=0;
        public int rightscore=0;

        public Cube(PictureBox ball)
        {
            this.ball = ball;
            ResetBall();
        }

        internal void ProcessMove()
        {
            ball.Location = new Point(ball.Location.X + xSpeed, Math.Max(World.topmap, Math.Min(462, ball.Location.Y + ySpeed)));

            if (ball.Location.Y == 462 || ball.Location.Y == World.topmap)
            {
                ySpeed *= -1;
            }

            if (ball.Location.X < World.leftOfWorld + ball.Width+5)
            {
                ResetBall();
                leftscore++;
            }
            if (ball.Location.X > World.rightOfWorld-60)
            {
                ResetBall();
                rightscore++;
            }
        }

        private void ResetBall()
        {
            ball.Location = new Point(World.leftOfWorld + World.rightOfWorld / 2, (World.topmap + World.lowmap / 2));

            do
            {
                xSpeed = rnd.Next(-6, 6);
                ySpeed = rnd.Next(-6, 6);
            } while (Math.Abs(xSpeed) + Math.Abs(ySpeed) <= 6);

        }
    }
}
