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
    public partial class listShenasnameh : Form
    {
        public bool select;
        public int PCmemeber;
        public int PNparts;
        public int Cregion;
        public listShenasnameh()
        {
            InitializeComponent();
        }

        private void listShenasnameh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hardware_IDDataSet.Shenasname' table. You can move, or remove it, as needed.
            this.shenasnameTableAdapter.Fill(this.hardware_IDDataSet.Shenasname);
            // TODO: This line of code loads data into the 'hardware_IDDataSet.shenasname' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'hardware_IDDataSet.Hardware_ID' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'hardware_IDDataSet.DataTable1' table. You can move, or remove it, as needed.

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            frmShenasnameh formshenasname = new frmShenasnameh();
            formshenasname.ShowDialog();
            this.shenasnameTableAdapter.Fill(this.hardware_IDDataSet.Shenasname);
        }

        private void comboBoxSearchType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSearchBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
