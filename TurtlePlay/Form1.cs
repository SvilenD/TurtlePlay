using Nakov.TurtleGraphics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TurtlePlay
{
    public partial class TurtlePlay : Form
    {
        public TurtlePlay()
        {
            InitializeComponent();
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            Turtle.Delay = 200;
            Turtle.PenColor = Color.Blue;
            for (int i = 1; i <= 3; i++)
            {
                Turtle.Rotate(120);
                Turtle.Forward(200);
            }
            Turtle.PenUp();
            Turtle.Rotate(-30);
            Turtle.Backward(50);
            Turtle.PenDown();
            Turtle.Backward(100);
            Turtle.PenUp();
            Turtle.Forward(150);
            Turtle.Rotate(120);
            Turtle.PenDown();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            Turtle.Reset();
        }

        private void buttonHide_Click(object sender, EventArgs e)
        {
            if (Turtle.ShowTurtle)
            {
                Turtle.ShowTurtle = false;
                this.buttonShowHideTurtle.Text = "Show Turtle";
            }
            else
            {
                Turtle.ShowTurtle = true;
                this.buttonShowHideTurtle.Text = "Hide Turtle";
            }
        }

        private void buttonHexagon_Click(object sender, EventArgs e)
        {
            Turtle.Delay = 100;
            Turtle.PenColor = Color.Green;
            Turtle.PenUp();
            Turtle.Forward(100);
            Turtle.PenDown();
            for (int i = 0; i <=6; i++)
            {
                Turtle.Rotate(60);
                Turtle.Forward(100);
            }
        }

        private void buttonStar_Click(object sender, EventArgs e)
        {
            Turtle.Delay = 100;
            Turtle.PenColor = Color.Yellow;
            Turtle.PenUp();
            Turtle.Rotate(180);
            Turtle.Forward(100);
            Turtle.PenDown();
            for (int i = 1; i <= 5; i++)
            {
                Turtle.Rotate(144);
                Turtle.Forward(200);
            }

        }

        private void buttonSpiral_Click(object sender, EventArgs e)
        {
            Turtle.Delay = 200;
            Turtle.PenColor = Color.Red;
            for (int i = 1; i < 21; i++)
            {
                Turtle.Forward(i * 10);
                Turtle.Rotate(60);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Turtle.PenUp();
            Turtle.Rotate(60);
            Turtle.Forward(100);
            Turtle.PenDown();
            Turtle.Delay = 200;
            Turtle.PenColor = Color.Yellow;
            for (int i = 1; i <=36; i++)
            {
                Turtle.Rotate(170);
                Turtle.Forward(200);
            }
            Turtle.ShowTurtle = false;
        }

        private void buttonTriangle_Click(object sender, EventArgs e)
        {
            Turtle.PenColor = Color.Red;
            Turtle.Delay = 200;
            Turtle.PenUp();
            Turtle.Rotate(300);
            Turtle.Forward(100);
            Turtle.PenDown();
            Turtle.Rotate(60);
            for (int i = 1; i <= 3; i++)
            {
                for (int n = 1; n <= 22; n++)
                {
                    Turtle.Rotate(120);
                    Turtle.Forward(n * 10);
                }
            }
        }
    }
}
