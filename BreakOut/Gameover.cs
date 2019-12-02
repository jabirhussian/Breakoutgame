using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BreakOut
{
    public partial class Gameover : Form
    {
        public Gameover()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Gameover_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void Gameover_KeyDown(object sender, KeyEventArgs e)
        {
            Form1 fr1 = new Form1();

            if(e.KeyCode == Keys.Escape)
            {
                this.Close();
                
            }
            if (e.KeyCode == Keys.F1)
            {
                this.Visible = false;
                fr1.Show();
            }
        }
    }
}
