using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BreakOut
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
            System.IO.Stream str5 = Properties.Resources.Intro;
            SoundPlayer intro = new SoundPlayer(str5);
            intro.Play();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnStrt_Click(object sender, EventArgs e)
        {
            Form1 fr1 = new Form1();
            this.Visible = false;
            fr1.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            About abt = new About();
            this.Visible = false;
            abt.Show();
        }
    }
}
