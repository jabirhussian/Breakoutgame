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
    public partial class Won : Form
    {
        public Won()
        {
            InitializeComponent();
        }

        private void Won_KeyDown(object sender, KeyEventArgs e)
        {
            Form1 fr1 = new Form1();

            if (e.KeyCode == Keys.F1)
            {
                this.Visible = false;
                fr1.Show();
            }

            if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
