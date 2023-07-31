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
    public partial class frmAdmin : Form
    {
        public bool update;
        public int PCadmin;
        public frmAdmin()
        {
            InitializeComponent();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hardware_IDDataSet.Admin' table. You can move, or remove it, as needed.
            this.adminTableAdapter.Fill(this.hardware_IDDataSet.Admin);
            if (update == true)
            {
                adminTableAdapter.FillByPCadmin(hardware_IDDataSet.Admin, PCadmin);
                if (hardware_IDDataSet.Admin.Rows.Count > 0)
                {
                    txtPersonnalCode.Text = hardware_IDDataSet.Admin.Rows[0]["PCadmin"].ToString();
                    txtFirstName.Text = hardware_IDDataSet.Admin.Rows[0]["Nadmin"].ToString();
                    txtLastName.Text = hardware_IDDataSet.Admin.Rows[0]["Ladmin"].ToString();
                    txtCode.Text = hardware_IDDataSet.Admin.Rows[0]["NCadmin"].ToString();
                    txtUserName.Text = hardware_IDDataSet.Admin.Rows[0]["Uadmin"].ToString();
                    txtPassword.Text = hardware_IDDataSet.Admin.Rows[0]["Padmin"].ToString();
                }
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtPersonnalCode.Text.Length < 4)
            {
                if (MessageBox.Show("تعداد کاراکتر های کد پرسنلی کمتر از 4 رقم است", "خطا", MessageBoxButtons.RetryCancel) == DialogResult.Retry)
                {
                    txtPersonnalCode.Clear();
                    txtPersonnalCode.Focus();
                    return;
                }
            }
            if (txtCode.Text.Length < 10)
            {
                if (MessageBox.Show("تعداد کاراکتر های کد ملی کمتر از 10 رقم است", "خطا", MessageBoxButtons.RetryCancel) == DialogResult.Retry)
                {
                    txtCode.Clear();
                    txtCode.Focus();
                    return;
                }
            }
            try
            {
                if (update == false)
                    adminTableAdapter.InsertQuery(int.Parse(txtPersonnalCode.Text), txtFirstName.Text, txtLastName.Text, txtCode.Text, txtUserName.Text, txtPassword.Text, null);
                else
                    adminTableAdapter.UpdateQuery(int.Parse(txtPersonnalCode.Text), txtFirstName.Text, txtLastName.Text, txtCode.Text, txtUserName.Text, txtPassword.Text, null, PCadmin);
                MessageBox.Show("ثبت اطلاعات با موفقیت انجام شد");
                this.Close();
            }
            catch
            {
                MessageBox.Show("ثبت اطلاعات با شکست مواجه شد", "خطا");
            }
        }

        private void btnBacke_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPersonnalCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPersonnalCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtCode.Focus();
        }

        private void txtCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtFirstName.Focus();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtFirstName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtLastName.Focus();
        }

        private void txtLastName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtUserName.Focus();
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtPassword.Focus();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSave.Focus();
        }
    }
}
