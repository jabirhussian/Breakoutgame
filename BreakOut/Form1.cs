using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace BreakOut
{
    public partial class Form1 : Form
    {
        public int tSpeed;
        public int lSpeed;
        public int points;
        public const int row = 9;
        public const int col = 9;
        public PictureBox[,] blocks;
        private Random rnd = new Random();
        int marginX = -70;
        int marginY = -60;
      
        public Form1()
        {
            InitializeComponent();

            tSpeed = 10;
            lSpeed = 10;
            setBlocks(); // calling SetBlocks Method to create an array of picturebox
            DoubleBuffered = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }
        // A method to create an array of pictureboxes
        private void setBlocks()
        {
            int blockHeight = 25;
            int blockWidth = 80;

            blocks = new PictureBox[row, col];

            for (int x = 0; x < row; x++)
            {
                for (int y = 0; y < col; y++)
                {
                    // creation of the array and giving properties
                    blocks[x, y] = new PictureBox();

                    blocks[x, y].Width = blockWidth;
                    blocks[x, y].Height = blockHeight;
                    blocks[x, y].Top = blockHeight * x - marginX;
                    blocks[x, y].Left = blockWidth * y - marginY;
                    blocks[x, y].BackColor = Color.FromArgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
                    blocks[x, y].BorderStyle = BorderStyle.Fixed3D;

                    this.Controls.Add(blocks[x, y]);
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Gameover govr = new Gameover();
            
            picBall.Top += tSpeed;
            picBall.Left += lSpeed;
            // movement of the ball
            if (picBall.Bottom > this.ClientSize.Height)
            {
                // Adding sound
                System.IO.Stream str2 = Properties.Resources.drop;
                SoundPlayer drop = new SoundPlayer(str2);
                drop.Play();
                timer1.Enabled = false;
                this.Visible = false;
                System.IO.Stream str3 = Properties.Resources.Gameover1;
                SoundPlayer go = new SoundPlayer(str3);
                go.Play();
                govr.Show();

            }

            if (picBall.Top < 0)
            {
                tSpeed = -tSpeed;
            }

            if (picBall.Right > this.ClientSize.Width)
            {
                lSpeed = -lSpeed;
            }

            if (picBall.Left < 0)
            {
                lSpeed = -lSpeed;
            }
            // Intersection of ball with paddle
            if (picBall.Bounds.IntersectsWith(picPaddle.Bounds) == true)
            {
                tSpeed = -tSpeed;
            }
            if (points == 200)
            {
                timer1.Interval = 20;
            }


            for (int x = 0; x < row; x++)
            {
                for (int y = 0; y < col; y++)
                {
                    //Ball intersect with bricks
                    if (picBall.Bounds.IntersectsWith(blocks[x, y].Bounds) && blocks[x, y].Visible == true)
                    {

                       //Adding sound
                        System.IO.Stream strm = Properties.Resources.hit2;
                        SoundPlayer player = new SoundPlayer(strm);
                        
                        player.Play();

                        blocks[x, y].Visible = false;
                        points += 10;
                        lblPoint.Text = points.ToString();
                        tSpeed = -tSpeed;

                        if (points == 810)
                        {
                            timer1.Enabled = false;
                            this.Visible = false;
                            Won won = new Won();
                            won.Show();
                            
                            
                        }


                    }
                }
            }


        }
       // movement of paddle
    private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            picPaddle.Left = e.X - (picPaddle.Width / 2);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }
        // keydown event 
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                label1.Visible = false;
                timer1.Enabled = true;
                System.IO.Stream str4 = Properties.Resources.Start;
                SoundPlayer start = new SoundPlayer(str4);
                start.Play();
            }

            if (e.KeyCode == Keys.P)
            {
                timer1.Enabled = false;
                
            }
            if (e.KeyCode == Keys.R)
            {
                timer1.Enabled = true;
            }

            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            
        }
    }
}
