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
    public partial class listPart : Form
    {
        public listPart()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmPart formpart = new frmPart(this);
            formpart.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmPart newpart = new frmPart(this);
            newpart.partId = GetSelectedId();
            newpart.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("آیا از حذف این رکورد اطمینان دارید", "تاییدیه حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                var db = DbContextSingleton.GetInstance();
                var part = db.Parts.Single(a => a.Id == GetSelectedId());
                db.Parts.Remove(part);
                if (db.SaveChanges() > 0)
                    Reload();
                else
                    MessageBox.Show("با شکست مواجه شد");
            }
        }

        private void comboBoxSearchType_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearchBox.Clear();
            txtSearchBox.Focus();
        }

        private void dgvParts_DoubleClick(object sender, EventArgs e)
        {
            listHardwareId sh = new listHardwareId();
            sh.partId = GetSelectedId();
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

        private void listPart_Load(object sender, EventArgs e)
        {
            Reload();
        }

        public void Reload()
        {
            var db = DbContextSingleton.GetInstance();
            IQueryable<Part> query = db.Parts;

            if (!string.IsNullOrWhiteSpace(txtSearchBox.Text))
            {
                switch (comboBoxSearchType.SelectedIndex)
                {
                    case 0:
                        query = db.Parts.Where(a => (a.Name).Contains(txtSearchBox.Text));
                        break;
                    case 1:
                        break;
                    default:
                        break;
                }
            }

            this.partBindingSource.DataSource = new BindingList<Part>(query.ToList());
        }

        public int GetSelectedId()
        {
            return Convert.ToInt32(dgvParts.CurrentRow.Cells[0].Value);
        }
    }
}
