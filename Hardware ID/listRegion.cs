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
    public partial class listRegion : Form
    {
        public listRegion()
        {
            InitializeComponent();
        }

        private void listRegion_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hardware_IDDataSet.Region' table. You can move, or remove it, as needed.
            this.regionTableAdapter.Fill(this.hardware_IDDataSet.Region);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmRegion formregion = new frmRegion();
            formregion.ShowDialog();
            this.regionTableAdapter.Fill(hardware_IDDataSet.Region);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int coderegion = int.Parse(dataGridView1.CurrentRow.Cells["Cregion"].Value.ToString());
            DialogResult result = MessageBox.Show("آیا از حذف این رکورد اطمینان دارید", "تاییدیه حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                regionTableAdapter.DeleteQueryRegion(coderegion);
                this.regionTableAdapter.Fill(this.hardware_IDDataSet.Region);
                MessageBox.Show("با موفقیت حذف شد");
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            listShenasnameh sregion = new listShenasnameh();
            sregion.select = true;
            sregion.Cregion = int.Parse(dataGridView1.CurrentRow.Cells["Cregion"].Value.ToString());
            sregion.ShowDialog();
            this.regionTableAdapter.Fill(this.hardware_IDDataSet.Region);
        }
    }
}
