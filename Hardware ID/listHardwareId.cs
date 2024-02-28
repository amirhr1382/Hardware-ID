using Hardware_ID.DatabaseContext;
using Hardware_ID.Models;
using Hardware_ID.ViewModels;
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
    public partial class listHardwareId : Form
    {
        public int memberId;
        public int partId;
        public int regionId;

        public listHardwareId()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmHardwareId newHardwareId = new frmHardwareId(this);
            newHardwareId.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmHardwareId newHardwareId = new frmHardwareId(this);
            newHardwareId.hardwareId = GetSelectedId();
            newHardwareId.ShowDialog();
        }

        private void comboBoxSearchType_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearchBox.Clear();
            txtSearchBox.Focus();
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

        private void listShenasnameh_Load(object sender, EventArgs e)
        {
            Reload();
        }

        public void Reload()
        {
            var db = DbContextSingleton.GetInstance();
            IQueryable<HardwareId> query = db.HardwareIds.Where(h =>
                (memberId == 0 || h.MemberId == memberId) &&
                (partId == 0 || h.PartId == partId) &&
                (regionId == 0 || h.RegionId == regionId)
            );

            if (!string.IsNullOrWhiteSpace(txtSearchBox.Text))
            {
                switch (comboBoxSearchType.SelectedIndex)
                {
                    case 0:
                        query = query.Where(h => h.Member.PersonelCode.Contains(txtSearchBox.Text));
                        break;
                    case 1:
                        query = query.Where(h => h.Part.Number.Contains(txtSearchBox.Text));
                        break;
                    case 2:
                        query = query.Where(h => h.Part.Number.Contains(txtSearchBox.Text));
                        break;
                        query = query.Where(h => h.Region.Code.Contains(txtSearchBox.Text));
                    default:
                        break;
                }
            }

            query = query.Include(q => q.Member).Include(q => q.Part).Include(q => q.Region);
            this.hardwareIdItemViewModelBindingSource.DataSource = HardwareIdItemViewModel.ListView(query.ToList());
        }

        public int GetSelectedId()
        {
            return Convert.ToInt32(dgvHardwareIds.CurrentRow.Cells[0].Value);
        }
    }
}
