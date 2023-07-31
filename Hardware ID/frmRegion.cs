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
    public partial class frmRegion : Form
    {
        public frmRegion()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtCregion.Text.Length<3)
            {
                if (MessageBox.Show("تعداد کاراکتر های کد سازمان کمتر از 3 رقم است", "خطا", MessageBoxButtons.RetryCancel) == DialogResult.Retry)
                {
                    txtCregion.Clear();
                    txtCregion.Focus();
                    return;
                }
            }
            try
            {
                regionTableAdapter.InsertQueryRegion(int.Parse(txtCregion.Text), txtNregion.Text);
                MessageBox.Show("ثبت اطلاعات با موفقیت انجام شد");
                this.Close();
            }
            catch
            {
                MessageBox.Show("ثبت اطلاعات با شکست مواجه شد", "خطا");
            }
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            btnSave.BackColor = Color.LightSeaGreen;
        }

        private void btnSave_MouseLeave(object sender, EventArgs e)
        {
            btnSave.BackColor = Color.Turquoise;
        }

        private void btnBacke_MouseHover(object sender, EventArgs e)
        {
            btnBacke.BackColor = Color.LightSeaGreen;
        }

        private void btnBacke_MouseLeave(object sender, EventArgs e)
        {
            btnBacke.BackColor = Color.Turquoise;
        }

        private void btnBacke_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRegion_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hardware_IDDataSet.Region' table. You can move, or remove it, as needed.
            this.regionTableAdapter.Fill(this.hardware_IDDataSet.Region);

        }

        private void txtCregion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCregion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtNregion.Focus();
        }

        private void txtNregion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSave.Focus();
        }
    }
}
