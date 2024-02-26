using Hardware_ID.DatabaseContext;
using Hardware_ID.Models;
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
        public int memberId;
        private listMember _listMember;

        public frmMember(listMember listMember)
        {
            InitializeComponent();

            _listMember = listMember;
        }

        private void frmMember_Load(object sender, EventArgs e)
        {
            if (memberId != 0)
            {
                var db = DbContextSingleton.GetInstance();
                var memberSelected = db.Members.Find(memberId);

                txtFirstName.Text = memberSelected.FirstName;
                txtLastName.Text = memberSelected.LastName;
                txtPersonnelCode.Text = memberSelected.PersonelCode;
                txtNationalCode.Text = memberSelected.NationalCode;
                txtMobile.Text = memberSelected.Mobile;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtPersonnelCode.Text.Length < 4)
            {
                if (MessageBox.Show("تعداد کاراکتر های کد پرسنلی کمتر از 4 رقم است", "خطا", MessageBoxButtons.RetryCancel) == DialogResult.Retry)
                {
                    txtPersonnelCode.Clear();
                    txtPersonnelCode.Focus();
                    return;
                }
            }
            if (txtNationalCode.Text.Length < 10)
            {
                if (MessageBox.Show("تعداد کاراکتر های کد ملی کمتر از 10 رقم است", "خطا", MessageBoxButtons.RetryCancel) == DialogResult.Retry)
                {
                    txtNationalCode.Clear();
                    txtNationalCode.Focus();
                    return;
                }
            }

            var db = DbContextSingleton.GetInstance();

            if (memberId != 0)
            {
                Member memberSelected = db.Members.Find(memberId);
                memberSelected.PersonelCode = txtPersonnelCode.Text;
                memberSelected.NationalCode = txtNationalCode.Text;
                memberSelected.FirstName = txtFirstName.Text;
                memberSelected.LastName = txtLastName.Text;
                memberSelected.Mobile = txtMobile.Text;
                db.Members.Update(memberSelected);
            }
            else
            {
                var memberNew = new Member()
                {
                    PersonelCode = txtPersonnelCode.Text,
                    NationalCode = txtNationalCode.Text,
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    Mobile = txtMobile.Text,
                    ImagePath = string.Empty
                };
                db.Members.Add(memberNew);
            }

            if (db.SaveChanges() > 0)
                _listMember.Reload();

            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Image Files(*.png;*.jpg)|*.png;*.jpg";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                picUser.ImageLocation = openFileDialog1.FileName;
            }
        }
    }
}
