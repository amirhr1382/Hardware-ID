using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hardware_ID
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ShenasnamehItem_Click(object sender, EventArgs e)
        {
            frmShenasnameh newform = new frmShenasnameh();
            newform.ShowDialog();
        }

        private void ExitItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MembersItem_Click(object sender, EventArgs e)
        {
            listMember formmember = new listMember();
            formmember.ShowDialog();
        }

        private void RegionItem_Click(object sender, EventArgs e)
        {
            
        }

        private void PartsItem_Click(object sender, EventArgs e)
        {
            listParts formpqarts = new listParts();
            formpqarts.ShowDialog();
        }

        private void RegionItem_Click_1(object sender, EventArgs e)
        {
            listRegion formregion = new listRegion();
            formregion.ShowDialog();
        }

        private void toolStripProgressBar1_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void SearchItem_Click(object sender, EventArgs e)
        {
            listShenasnameh formshenasname = new listShenasnameh();
            formshenasname.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
