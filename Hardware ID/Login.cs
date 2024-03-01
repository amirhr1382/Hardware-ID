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
            var db = DbContextSingleton.GetInstance();

            if (x > 3)
            {
                txtUserName.Enabled = false;
                txtPassword.Enabled = false;
                timer1.Enabled = true;
            }

            Admin admin = db.Admins.SingleOrDefault(a => a.Username == txtUserName.Text && a.Password == txtPassword.Text);
            if (admin != null)
            {
                successed = true;
                notifyIcon1.BalloonTipText = "به برنامه شناسنامه سخت افزاری خوش آمدید";
                notifyIcon1.BalloonTipTitle = admin.Username;
                notifyIcon1.Icon = SystemIcons.Information;
                notifyIcon1.ShowBalloonTip(10);
                this.Hide();
                Main main = new Main();
                main.ShowDialog();
            }
            else
            {
                MessageBox.Show("نام کاربری یا گذرواژه اشتباه است");
                txtUserName.Clear();
                txtPassword.Clear();
                txtUserName.Focus();
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
