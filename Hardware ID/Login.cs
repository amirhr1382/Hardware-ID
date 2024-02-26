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
    public partial class Login : Form
    {
        public bool successed;
        int x = 1, t = 60;
        public Login()
        {
            InitializeComponent();
        }

        private void chkPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPassword.Checked == true)
                txtPassword.PasswordChar = '\0';
            else
                txtPassword.PasswordChar = '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            x++;
            if (x > 3)
            {
                txtUserName.Enabled = false;
                txtPassword.Enabled = false;
                timer1.Enabled = true;
            }
            //adminTableAdapter.FillByUserPasswordAdmin(hardware_IDDataSet.Admin, txtUserName.Text, txtPassword.Text);
            //if (hardware_IDDataSet.Admin.Rows.Count > 0)
            //{
            //    successed = true;
            //    notifyIcon1.BalloonTipText = "به برنامه شناسنامه سخت افزاری خوش آمدید";
            //    notifyIcon1.BalloonTipTitle = "Admin";
            //    notifyIcon1.Icon = SystemIcons.Information;
            //    notifyIcon1.ShowBalloonTip(10);
            //    this.Hide();
            //    Main main = new Main();
                

            //    main.ShowDialog();
            //}
            //else
            //{
            //    MessageBox.Show("نام کاربری یا گذرواژه اشتباه است");
            //    txtUserName.Clear();
            //    txtPassword.Clear();
            //    txtUserName.Focus();
            //}
            
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtPassword.Focus();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogin.Focus();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hardware_IDDataSet.Admin' table. You can move, or remove it, as needed.
            //this.adminTableAdapter.Fill(this.hardware_IDDataSet.Admin);

        }
    }
}
