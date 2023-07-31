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
    public partial class listParts : Form
    {
        public listParts()
        {
            InitializeComponent();
        }

        private void listParts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hardware_IDDataSet.Parts' table. You can move, or remove it, as needed.
            this.partsTableAdapter.Fill(this.hardware_IDDataSet.Parts);

        }

        private void btnAddP_Click(object sender, EventArgs e)
        {
            frmParts formparts = new frmParts();
            formparts.ShowDialog();
            this.partsTableAdapter.Fill(this.hardware_IDDataSet.Parts);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int numberParts =int.Parse( dataGridView1.CurrentRow.Cells["PNparts"].Value.ToString());
            DialogResult result = MessageBox.Show("آیا از حذف این رکورد اطمینان دارید", "تاییدیه حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                partsTableAdapter.DeleteQueryParts(numberParts);
                this.partsTableAdapter.Fill(this.hardware_IDDataSet.Parts);
                MessageBox.Show("با موفقیت حذف شد");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmParts newparts = new frmParts();
            newparts.update = true;
            newparts.PNparts = int.Parse(dataGridView1.CurrentRow.Cells["PNparts"].Value.ToString());
            newparts.ShowDialog();
            this.partsTableAdapter.Fill(this.hardware_IDDataSet.Parts);
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            listShenasnameh sparts = new listShenasnameh();
            sparts.select = true;
            sparts.PNparts = int.Parse(dataGridView1.CurrentRow.Cells["PNparts"].Value.ToString());
            sparts.ShowDialog();
            this.partsTableAdapter.Fill(this.hardware_IDDataSet.Parts);
        }

        private void comboBoxSearchType_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearchBox.Clear();
            txtSearchBox.Focus();
        }

        private void txtSearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                if (txtSearchBox.Text.Length != 0)
                {
                    if (comboBoxSearchType.SelectedIndex == 0)
                    {
                        this.partsBindingSource.DataSource = this.partsTableAdapter.GetDataByParts(int.Parse(txtSearchBox.Text));
                    }
                    if (comboBoxSearchType.SelectedIndex == 1)
                    {
                        this.partsBindingSource.DataSource = this.partsTableAdapter.GetDataByNameParts(txtSearchBox.Text);
                    }
                    if (comboBoxSearchType.SelectedIndex == 2)
                    {
                        this.partsBindingSource.DataSource = this.partsTableAdapter.GetDataByModelparts(txtSearchBox.Text);
                    }
                }
                else
                    this.partsBindingSource.DataSource = this.partsTableAdapter.GetData();
            } 
        }

        private void txtSearchBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
