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
    public partial class frmShenasnameh : Form
    {
        public bool update;
        public int Row;
        public frmShenasnameh()
        {
            InitializeComponent();
        }

        private void txtPersonnalCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBacke_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtNameParts.Text = "";
            txtModelParts.Text = "";
            txtSdata.Text = "";
            txtEdata.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
               /* if (update == false)
                   // shenasnameTableAdapter.InsertQuery(int.Parse(comboBox1.SelectedValue.ToString()), int.Parse(comboBoxNregion.SelectedValue.ToString()), int.Parse(comboBox2.SelectedValue.ToString()), txtSdata.Text, txtEdata.Text, checkBox1.Checked);
                else
                   // shenasnameTableAdapter.UpdateQuery(int.Parse(comboBox1.SelectedValue.ToString()), int.Parse(comboBoxNregion.SelectedValue.ToString()), int.Parse(comboBox2.SelectedValue.ToString()), txtSdata.Text, txtEdata.Text, checkBox1.Checked, Row);
               */
                MessageBox.Show("ثبت اطلاعات با موفقیت انجام شد");
                this.Close();
            }
            catch
            {
                MessageBox.Show("ثبت اطلاعات با شکست مواجه شد", "خطا");
            }


        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void frmShenasnameh_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hardware_IDDataSet.Shenasname' table. You can move, or remove it, as needed.
            this.shenasnameTableAdapter.Fill(this.hardware_IDDataSet.Shenasname);
            // TODO: This line of code loads data into the 'hardware_IDDataSet.Hardware_ID' table. You can move, or remove it, as needed.
            this.hardware_IDTableAdapter.Fill(this.hardware_IDDataSet.Hardware_ID);
            // TODO: This line of code loads data into the 'hardware_IDDataSet.Parts' table. You can move, or remove it, as needed.
            this.partsTableAdapter.Fill(this.hardware_IDDataSet.Parts);
            // TODO: This line of code loads data into the 'hardware_IDDataSet.Member' table. You can move, or remove it, as needed.
            this.memberTableAdapter.Fill(this.hardware_IDDataSet.Member);
            // TODO: This line of code loads data into the 'hardware_IDDataSet.Region' table. You can move, or remove it, as needed.
            this.regionTableAdapter.Fill(this.hardware_IDDataSet.Region);

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
