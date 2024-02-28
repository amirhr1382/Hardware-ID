using Hardware_ID.DatabaseContext;
using Microsoft.EntityFrameworkCore;
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
    public partial class listAdmin : Form
    {
        public listAdmin()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAdmin frm = new frmAdmin(this);
            frm.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmAdmin newadmin = new frmAdmin(this);
            newadmin.adminId = GetSelectedId();
            newadmin.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("آیا از حذف این رکورد اطمینان دارید", "تاییدیه حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var db = DbContextSingleton.GetInstance();
                var admin = db.Admins.Single(a => a.Id == GetSelectedId());
                db.Admins.Remove(admin);
                if (db.SaveChanges() > 0)
                    Reload();
                else
                    MessageBox.Show("با شکست مواجه شد");
            }
        }

        private void listAdmin_Load(object sender, EventArgs e)
        {
            Reload();
        }

        public void Reload()
        {
            var db = DbContextSingleton.GetInstance();
            db.Database.EnsureCreated();
            db.Admins.Load();
            this.adminBindingSource.DataSource = db.Admins.Local.ToBindingList();
        }

        public int GetSelectedId()
        {
            return Convert.ToInt32(dgvAdmins.CurrentRow.Cells[0].Value);
        }
    }
}
