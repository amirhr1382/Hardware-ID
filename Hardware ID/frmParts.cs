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
    public partial class frmParts : Form
    {
        public bool update;
        public int PNparts;
        public frmParts()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_MouseHover(object sender, EventArgs e)
        {
            btnSave.BackColor = Color.LightSeaGreen;
        }

        private void btnSave_MouseLeave(object sender, EventArgs e)
        {
            btnSave.BackColor = Color.Turquoise;
        }

        private void btnDelete_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void btnBacke_MouseHover(object sender, EventArgs e)
        {
            btnBacke.BackColor = Color.LightSeaGreen;
        }

        private void btnBacke_MouseLeave(object sender, EventArgs e)
        {
            btnBacke.BackColor = Color.Turquoise;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtPNparts.Text.Length< 9)
            {
                if (MessageBox.Show("تعداد کاراکتر های کد ملی کمتر از 9 رقم است", "خطا", MessageBoxButtons.RetryCancel) == DialogResult.Retry)
                {
                    txtPNparts.Clear();
                    txtPNparts.Focus();
                    return;
                }
            }
            try
            {
                if (update == false)
                    partsTableAdapter.InsertQueryParts(int.Parse(txtPNparts.Text), txtNameParts.Text, txtModelParts.Text);
                else
                    partsTableAdapter.UpdateQueryParts(int.Parse(txtPNparts.Text), txtNameParts.Text, txtModelParts.Text, PNparts);
                MessageBox.Show("ثبت اطلاعات با موفقیت انجام شد");
                this.Close();
            }
            catch
            {
                MessageBox.Show("ثبت اطلاعات با شکست مواجه شد", "خطا");
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtNameParts.Text = "";
            txtModelParts.Text = "";
            txtPNparts.Text = "";
        }

        private void btnBacke_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmParts_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hardware_IDDataSet.Parts' table. You can move, or remove it, as needed.
            this.partsTableAdapter.Fill(this.hardware_IDDataSet.Parts);
            if (update == true)
            {
                partsTableAdapter.FillByParts(hardware_IDDataSet.Parts,PNparts);
                if (hardware_IDDataSet.Parts.Rows.Count > 0)
                {
                    txtPNparts.Text = hardware_IDDataSet.Parts.Rows[0]["PNparts"].ToString();
                    txtNameParts.Text = hardware_IDDataSet.Parts.Rows[0]["Nparts"].ToString();
                    txtModelParts.Text = hardware_IDDataSet.Parts.Rows[0]["Mparts"].ToString();
                }
            }
        }

        private void txtNameParts_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtModelParts.Focus();
        }

        private void txtModelParts_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtPNparts.Focus();
        }

        private void txtPNparts_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSave.Focus();
        }
    }
}
