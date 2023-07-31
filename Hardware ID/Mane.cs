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
    public partial class Mane : Form
    {
        public Mane()
        {
            InitializeComponent();
        }

        private void Mane_Load(object sender, EventArgs e)
        {

        }

        private void AdminItem_Click(object sender, EventArgs e)
        {
            listAdmin formadmin = new listAdmin();
            formadmin.ShowDialog();
        }

        private void MemberItem_Click(object sender, EventArgs e)
        {
            listMember formmember = new listMember();
            formmember.ShowDialog();
        }

        private void SakhtafzaeItem_Click(object sender, EventArgs e)
        {
            frmShenasnameh newform = new frmShenasnameh();
            newform.ShowDialog();
        }

        private void ExitItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void PartsItem_Click(object sender, EventArgs e)
        {
            listParts formpqarts = new listParts();
            formpqarts.ShowDialog();
        }

        private void RegionItem_Click(object sender, EventArgs e)
        {
            listRegion formregion = new listRegion();
            formregion.ShowDialog();
        }

        private void SearchItem_Click(object sender, EventArgs e)
        {
            listShenasnameh formshenasname = new listShenasnameh();
            formshenasname.ShowDialog();
        }
    }
}
