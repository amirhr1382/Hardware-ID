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
    public partial class listRegion : Form
    {
        public listRegion()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmRegion formregion = new frmRegion(this);
            formregion.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmRegion formregion = new frmRegion(this);
            formregion.regioId = GetSelectedId();
            formregion.ShowDialog();
        }

        private void dgvRegion_DoubleClick(object sender, EventArgs e)
        {
            listHardwareId sh = new listHardwareId();
            sh.regionId = GetSelectedId();
            sh.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var db = DbContextSingleton.GetInstance();
            int hdCount = db.HardwareIds.Count(h => h.RegionId == GetSelectedId());
            if (hdCount > 0)
                MessageBox.Show($"تعداد {hdCount} شناسنامه سخت افزاری برای این سازمان ثبت شده است", "امکان حذف وجود ندارد", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                DialogResult result = MessageBox.Show("آیا از حذف این رکورد اطمینان دارید", "تاییدیه حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    var region = db.Regions.Single(a => a.Id == GetSelectedId());
                    db.Regions.Remove(region);
                    if (db.SaveChanges() > 0)
                        Reload();
                    else
                        MessageBox.Show("با شکست مواجه شد");
                }
            }
        }

        private void listRegion_Load(object sender, EventArgs e)
        {
            Reload();
        }

        public void Reload()
        {
            var db = DbContextSingleton.GetInstance();
            IQueryable<Models.Region> query = db.Regions;
            this.regionBindingSource.DataSource = new BindingList<Models.Region>(query.ToList());
        }

        public int GetSelectedId()
        {
            return Convert.ToInt32(dgvRegions.CurrentRow.Cells[0].Value);
        }
    }
}
