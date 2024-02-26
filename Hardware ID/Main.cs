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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void AdminItem_Click(object sender, EventArgs e)
        {
            listAdmin listAdmin = new listAdmin();
            listAdmin.ShowDialog();
        }

        private void MemberItem_Click(object sender, EventArgs e)
        {
            listMember listMember = new listMember();
            listMember.ShowDialog();
        }

        private void PartItem_Click(object sender, EventArgs e)
        {
            listPart listPart = new listPart();
            listPart.ShowDialog();
        }

        private void RegionItem_Click(object sender, EventArgs e)
        {
            listRegion listRegion = new listRegion();
            listRegion.ShowDialog();
        }

        private void HardwareIdItem_Click(object sender, EventArgs e)
        {
            listHardwareId listShenasnameh = new listHardwareId();
            listShenasnameh.ShowDialog();
        }

        private void SearchItem_Click(object sender, EventArgs e)
        {
            //listShenasnameh formshenasname = new listShenasnameh();
            //formshenasname.ShowDialog();
        }

        private void ExitItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
