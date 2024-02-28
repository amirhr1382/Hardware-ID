using Hardware_ID.DatabaseContext;
using Hardware_ID.Models;
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
    public partial class listMember : Form
    {
        public listMember()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmMember formmember = new frmMember(this);
            formmember.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmMember newmember = new frmMember(this);
            newmember.memberId = GetSelectedId();
            newmember.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var db = DbContextSingleton.GetInstance();
            int hdCount = db.HardwareIds.Count(h => h.MemberId == GetSelectedId());
            if (hdCount > 0)
                MessageBox.Show($"تعداد {hdCount} شناسنامه سخت افزاری برای این عضو ثبت شده است.", "امکان حذف وجود ندارد", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                DialogResult result = MessageBox.Show("آیا از غیر فعال کردن این رکورد اطمینان دارید", "تاییدیه غیر فعال", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    var member = db.Members.Single(a => a.Id == GetSelectedId());
                    db.Members.Remove(member);
                    if (db.SaveChanges() > 0)
                        Reload();
                    else
                        MessageBox.Show("با شکست مواجه شد");
                }
            }
        }

        private void comboBoxSearchType_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearchBox.Clear();
            txtSearchBox.Focus();
        }

        private void dgvMember_DoubleClick(object sender, EventArgs e)
        {
            listHardwareId sh = new listHardwareId();
            sh.memberId = GetSelectedId();
            sh.ShowDialog();
        }

        private void txtSearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            var db = DbContextSingleton.GetInstance();
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                Reload();
            }
        }

        private void listMember_Load(object sender, EventArgs e)
        {
            Reload();
        }

        private void btnDisableOrEnable_Click(object sender, EventArgs e)
        {
            var db = DbContextSingleton.GetInstance();
            Member member = db.Members.Single(m => m.Id == GetSelectedId());
            member.IsEnable = !member.IsEnable;
            db.Members.Update(member);
            Reload();
        }

        public void Reload()
        {
            var db = DbContextSingleton.GetInstance();
            IQueryable<Member> query = db.Members;

            if (!string.IsNullOrWhiteSpace(txtSearchBox.Text))
            {
                switch (comboBoxSearchType.SelectedIndex)
                {
                    case 0:
                        query = db.Members.Where(a => (a.FirstName + " " + a.LastName).Contains(txtSearchBox.Text));
                        break;
                    case 1:
                        query = db.Members.Where(a => a.NationalCode.Contains(txtSearchBox.Text));
                        break;
                    case 2:
                        query = db.Members.Where(a => a.Mobile.Contains(txtSearchBox.Text));
                        break;
                    default:
                        break;
                }
            }

            this.memberBindingSource.DataSource = new BindingList<Member>(query.ToList());
        }

        public int GetSelectedId()
        {
            return Convert.ToInt32(dgvMembers.CurrentRow.Cells[0].Value);
        }
    }
}
