using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kaptanHuso
{
    public partial class Form1 : Form
    {

        bool goLeft, goRight, boostbool;

        int speed = 8;
        int boost = 0;
        string facing = "right";

        
        
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            boostBar.Minimum = 0;
            boostBar.Maximum = 100;
            boostBar.Value = boost;
        }

        private void gamekeydown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                goLeft = true;
                facing = "left";
                captan.Image = Properties.Resources.solKaptan;
                
            }


            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
                facing = "Right";
                captan.Image = Properties.Resources.sagKaptan;
            }

            if (e.KeyCode == Keys.Space)
            {
                boostbool = true;
            }
        }

        private void boostBar_Click(object sender, EventArgs e)
        {

        }

        private void MainTimerEvent(object sender, EventArgs e)
        {
            if(goLeft == true && captan.Left > 0)
            {
                captan.Left -= speed;
            }

            if(goRight == true && captan.Left + captan.Width < this.ClientSize.Width)
            {
                captan.Left += speed;
            }

            if (boostbool == true && boost > 0)
            {
                speed = 12;
                if(boost>4)
                boost = boost - 5;

            }
            else
            {
                speed = 8;
                if(boost<100)
                    boost = boost + 1;
            }
            boostBar.Value = boost;
        }

        private void gamekeyup(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
                

            }

            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
               
            }

            if (e.KeyCode == Keys.Space)
            {
                boostbool = false;
            }
        }

        

        }

        

       
    }

