using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    public partial class Form1 : Form
    {
        bool isUpPressed, isDownPressed, isUpPressedply2, isDownPressedply2;
        const int movementofmovement = 5; //topmap=0,lowmap=365;
        Cube cube;
        

        public Form1()
        {
            InitializeComponent();
            cube = new Cube(ball);
        }

        public void Score()
        {
            leftplayerscore.Text = Convert.ToString(cube.rightscore);
            rightplayerscore.Text = Convert.ToString(cube.leftscore);
        }

        public void Collision()
        {
            if (left.Bounds.IntersectsWith(ball.Bounds)|| right.Bounds.IntersectsWith(ball.Bounds))
            {
                cube.xSpeed *= -1;
            }
            while (left.Bounds.IntersectsWith(ball.Bounds) || right.Bounds.IntersectsWith(ball.Bounds))
            {
                cube.ProcessMove();
            }
            
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to close the game?", "Exit", MessageBoxButtons.YesNo);

            if (dialog == DialogResult.Yes)
            {
               // Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void timer_Tick(object sender, EventArgs e) 
        {
            if (isUpPressed) {right.Location = new Point(right.Location.X, Math.Max(World.topmap, Math.Min(World.lowmap, right.Location.Y- movementofmovement)));}
            if (isDownPressed) {right.Location = new Point(right.Location.X, Math.Max(World.topmap, Math.Min(World.lowmap, right.Location.Y + movementofmovement)));}

            if (isUpPressedply2) { left.Location = new Point(left.Location.X,Math.Max(World.topmap, Math.Min(World.lowmap, left.Location.Y - movementofmovement))); }
            if (isDownPressedply2) { left.Location = new Point(left.Location.X, Math.Max(World.topmap, Math.Min(World.lowmap, left.Location.Y + movementofmovement))); }

            Score();
            cube.ProcessMove();
            Collision();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Up) { isUpPressed = true;}
            else if (e.KeyCode == Keys.Down) { isDownPressed = true; }

            if (e.KeyCode == Keys.W) { isUpPressedply2 = true; }
            else if (e.KeyCode == Keys.S) { isDownPressedply2 = true; }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up) {isUpPressed = false;}
            else if (e.KeyCode == Keys.Down){ isDownPressed = false;}

            if (e.KeyCode == Keys.W) { isUpPressedply2 = false; }
            else if (e.KeyCode == Keys.S) { isDownPressedply2 = false; }
        }

    }
}
