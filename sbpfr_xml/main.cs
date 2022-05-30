using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sbpfr_xml
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            logo.ftest.MdiParent = this;
            logo.ftest.Show();
        }

        private void main_Shown(object sender, EventArgs e)
        {
            logo.loadStatus = true;
        }
    }
}
