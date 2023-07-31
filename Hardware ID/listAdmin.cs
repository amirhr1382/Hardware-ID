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
    public partial class listAdmin : Form
    {
        public listAdmin()
        {
            InitializeComponent();
        }

        private void listAdmin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hardware_IDDataSet.Admin' table. You can move, or remove it, as needed.
            this.adminTableAdapter.Fill(this.hardware_IDDataSet.Admin);

        }

        private void btnAddP_Click(object sender, EventArgs e)
        {
            frmAdmin formparts = new frmAdmin();
            formparts.ShowDialog();
            this.adminTableAdapter.Fill(this.hardware_IDDataSet.Admin);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmAdmin newadmin = new frmAdmin();
            newadmin.update = true;
            newadmin.PCadmin = int.Parse(dataGridView1.CurrentRow.Cells["PCadmin"].Value.ToString());
            newadmin.ShowDialog();
            this.adminTableAdapter.Fill(this.hardware_IDDataSet.Admin);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int numberadmin = int.Parse(dataGridView1.CurrentRow.Cells["PCadmin"].Value.ToString());
            DialogResult result = MessageBox.Show("آیا از حذف این رکورد اطمینان دارید", "تاییدیه حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                adminTableAdapter.DeleteQuery(numberadmin);
                this.adminTableAdapter.Fill(this.hardware_IDDataSet.Admin);
                MessageBox.Show("با موفقیت حذف شد");
            }
        }
    }
}
