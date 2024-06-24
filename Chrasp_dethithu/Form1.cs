using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chrasp_dethithu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void hệThốngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tiệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void giớiThiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("chương trình tiện ích ", "thông tin", MessageBoxButtons.OK);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void địnhDạngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dindang dindang = new dindang();
            dindang.ShowDialog();   
        }
    }
}
