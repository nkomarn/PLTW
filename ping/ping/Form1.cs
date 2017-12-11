using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace ping
{
    public partial class Form1 : Form
    {
        public static bool gameStart;

        public Form1()
        {
            InitializeComponent();
            InitTimer();
            KeyDown += new KeyEventHandler(pictureBox2_KeyDown);
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            


        }

        private Timer timer1;
        public void InitTimer()
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Interval = 100; // in miliseconds
            timer1.Start();
        }
       
        private int Xspeed = 10;
        private int Yspeed = 10;
        private int scoreP1 = 0;
        private int scoreP2 = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {


            if (pictureBox1.Location.X >= 450)
            {
                pictureBox1.Location = new Point(225, 225);
                gameStart = false;
                scoreP1 = scoreP1 + 1;
                P1ScoreBox();
            }
            if (pictureBox1.Location.X <= 0)
            {
                pictureBox1.Location = new Point(225, 225);
                gameStart = false;
                scoreP2 = scoreP2 + 1;
                P2ScoreBox();
            }
            if (pictureBox1.Location.Y >= 450)
            {
                Yspeed = -Yspeed;
            }
            if (pictureBox1.Location.Y <= 0)
            {
                Yspeed = -Yspeed;
            }
            if (gameStart)
            {
                pictureBox1.Location = new Point(pictureBox1.Location.X + Xspeed, pictureBox1.Location.Y + Yspeed);
            }
            if (pictureBox1.Bounds.IntersectsWith(pictureBox2.Bounds))
            {
                Xspeed = -Xspeed;
            }
            if (pictureBox1.Bounds.IntersectsWith(pictureBox3.Bounds))
            {
                Xspeed = -Xspeed;

            }
        }

            private void pictureBox2_KeyDown(object sender, KeyEventArgs e) {
                if (e.KeyCode == Keys.Space) {
                gameStart = true;
                }
                if (e.KeyCode == Keys.W)
                {

                    pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y - 5);
                }
                if (e.KeyCode == Keys.S)
                {
                    pictureBox2.Location = new Point(pictureBox2.Location.X, pictureBox2.Location.Y + 5);
                }
                if (pictureBox2.Location.Y >= 450)
                {
                    pictureBox2.Location = new Point(pictureBox2.Location.X, 450);
                }
                if (pictureBox2.Location.Y <= 0)
                {
                    pictureBox2.Location = new Point(pictureBox2.Location.X, 0);
                }
            
            
            
                if (e.KeyCode == Keys.Up)
                {

                    pictureBox3.Location = new Point(pictureBox3.Location.X, pictureBox3.Location.Y - 5);
                }
                if (e.KeyCode == Keys.Down)
                {
                    pictureBox3.Location = new Point(pictureBox3.Location.X, pictureBox3.Location.Y + 5);
                }
                if (pictureBox3.Location.Y >= 450)
                {
                    pictureBox3.Location = new Point(pictureBox3.Location.X, 450);
                }
                if (pictureBox3.Location.Y <= 0)
                {
                    pictureBox3.Location = new Point(pictureBox3.Location.X, 0);
                }
            }
        private  void P1ScoreBox()
        {
            label2.Text = "" + scoreP1;
        }
        private void P2ScoreBox()
        {
            label1.Text = "" + scoreP2;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    
        
    }

