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
    public partial class frmMember : Form
    {
        public bool update;
        public int PCmemeber;
        public frmMember()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files(*.png;*.jpg)|*.png;*.jpg";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                picUser.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtPersonnalCode.Text.Length<4)
            {
                if(MessageBox.Show("تعداد کاراکتر های کد پرسنلی کمتر از 4 رقم است","خطا",MessageBoxButtons.RetryCancel)==DialogResult.Retry)
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
                    memberTableAdapter.InsertQueryMember(int.Parse(txtPersonnalCode.Text), txtFirstName.Text, txtLastName.Text, txtCode.Text, txtPhone.Text, null);
                else
                    memberTableAdapter.UpdateQueryMember(int.Parse(txtPersonnalCode.Text), txtFirstName.Text, txtLastName.Text, txtCode.Text, txtPhone.Text, null, PCmemeber);
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
            txtPersonnalCode.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtCode.Text = "";
            txtPhone.Text = "";
        }

        private void btnBacke_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPic_MouseHover(object sender, EventArgs e)
        {
            btnPic.BackColor = Color.LightSeaGreen;
        }

        private void btnPic_MouseLeave(object sender, EventArgs e)
        {
            btnPic.BackColor = Color.Turquoise;
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
            //btnDelete.BackColor = Color.LightSeaGreen;
        }

        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
          // btnDelete.BackColor = Color.Turquoise;
        }

        private void btnBacke_MouseHover(object sender, EventArgs e)
        {
            btnBacke.BackColor = Color.LightSeaGreen;
        }

        private void btnBacke_MouseLeave(object sender, EventArgs e)
        {
            btnBacke.BackColor = Color.Turquoise;
        }

        private void frmMember_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hardware_IDDataSet.Member' table. You can move, or remove it, as needed.
            this.memberTableAdapter.Fill(this.hardware_IDDataSet.Member);
            if(update==true)
            {
                memberTableAdapter.FillByPCmemeber(hardware_IDDataSet.Member, PCmemeber);
                if(hardware_IDDataSet.Member.Rows.Count>0)
                {
                    txtPersonnalCode.Text = hardware_IDDataSet.Member.Rows[0]["PCmemeber"].ToString();
                    txtFirstName.Text = hardware_IDDataSet.Member.Rows[0]["Nmemeber"].ToString();
                    txtLastName.Text = hardware_IDDataSet.Member.Rows[0]["Lmemeber"].ToString();
                    txtCode.Text = hardware_IDDataSet.Member.Rows[0]["NCmemeber"].ToString();                   
                    txtPhone.Text = hardware_IDDataSet.Member.Rows[0]["tel"].ToString();
                }
            }
        }

        private void txtPersonnalCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtCode.Focus();
        }

        private void txtFirstName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtLastName.Focus();
        }

        private void txtCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtFirstName.Focus();
        }

        private void txtLastName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtPhone.Focus();
        }

        private void txtPhone_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnSave.Focus();
        }
    }
}
