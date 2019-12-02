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
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void About_KeyDown(object sender, KeyEventArgs e)
        {
            Start strt = new Start();

            if (e.KeyCode == Keys.Escape)
            {
                this.Visible = false;
                strt.Show();
            }
        }
    }
}
