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
    public partial class frmAdmin : Form
    {
        public int adminId;
        private listAdmin _listAdmin;

        public frmAdmin(listAdmin listAdmin)
        {
            InitializeComponent();

            _listAdmin = listAdmin;
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            if (adminId != 0)
            {
                var db = DbContextSingleton.GetInstance();
                var adminSelected = db.Admins.Find(adminId);

                //txtPersonelCode.Text = adminSelected;
                txtFirstName.Text = adminSelected.FirstName;
                txtLastName.Text = adminSelected.LastName;
                txtNationalCode.Text = adminSelected.NationalCode;
                txtUserName.Text = adminSelected.Username;
                txtPassword.Text = adminSelected.Password;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
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

            if (adminId != 0)
            {
                Admin adminSelected = db.Admins.Find(adminId);
                adminSelected.Username = txtUserName.Text;
                adminSelected.Password = txtPassword.Text;
                adminSelected.FirstName = txtFirstName.Text;
                adminSelected.LastName = txtLastName.Text;
                adminSelected.NationalCode = txtNationalCode.Text;
                db.Admins.Update(adminSelected);
            }
            else
            {
                var adminNew = new Admin()
                {
                    Username = txtUserName.Text,
                    Password = txtPassword.Text,
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    NationalCode = txtNationalCode.Text,
                    ImagePath = string.Empty
                };
                db.Admins.Add(adminNew);
            }

            if (db.SaveChanges() > 0)
                _listAdmin.Reload();

            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
