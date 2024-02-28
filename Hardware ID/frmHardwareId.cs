using Hardware_ID.DatabaseContext;
using Hardware_ID.Models;
using Hardware_ID.Utilities.DateTimeUtilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hardware_ID
{
    public partial class frmHardwareId : Form
    {
        public int hardwareId;
        public listHardwareId _listHardwareId { get; set; }

        public frmHardwareId(listHardwareId listHardwareId)
        {
            InitializeComponent();
            _listHardwareId = listHardwareId;
        }

        private void frmHardwareId_Load(object sender, EventArgs e)
        {
            var db = DbContextSingleton.GetInstance();

            cmbPersonelCode.ValueMember = "Id";
            cmbPersonelCode.DisplayMember = "PersonelCode";
            cmbPersonelCode.DataSource = db.Members.ToList();

            cmbRegionName.ValueMember = "Id";
            cmbRegionName.DisplayMember = "Name";
            cmbRegionName.DataSource = db.Regions.ToList();

            cmbPartNumber.ValueMember = "Id";
            cmbPartNumber.DisplayMember = "Number";
            cmbPartNumber.DataSource = db.Parts.ToList();

            if (hardwareId != 0)
            {
                var hdSelected = db.HardwareIds.Find(hardwareId);

                cmbPersonelCode.SelectedValue = hdSelected.MemberId;
                cmbRegionName.SelectedValue = hdSelected.RegionId;
                cmbPartNumber.SelectedValue = hdSelected.PartId;
                txtStartDate.Text = DateConvert.GregorianToPersian(hdSelected.StartDate);
                txtEndDate.Text = DateConvert.GregorianToPersian(hdSelected.EndDate);
                chkIsTransferred.Checked = hdSelected.IsTransferred;
            }
        }

        private void cmbPersonelCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            var db = DbContextSingleton.GetInstance();
            int selectedMemberId = Convert.ToInt32(cmbPersonelCode.SelectedValue);
            Member member = db.Members.Single(m => m.Id == selectedMemberId);
            txtFirstName.Text = member.FirstName;
            txtLastName.Text = member.LastName;
        }

        private void cmbPartNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            var db = DbContextSingleton.GetInstance();
            int selectedPartId = Convert.ToInt32(cmbPartNumber.SelectedValue);
            Part part = db.Parts.Single(m => m.Id == selectedPartId);
            txtPartName.Text = part.Name;
            txtPartModel.Text = part.Model;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var db = DbContextSingleton.GetInstance();

            if (hardwareId != 0)
            {
                HardwareId hdSelected = db.HardwareIds.Find(hardwareId);
                hdSelected.MemberId = Convert.ToInt32(cmbPersonelCode.SelectedValue);
                hdSelected.RegionId = Convert.ToInt32(cmbRegionName.SelectedValue);
                hdSelected.PartId = Convert.ToInt32(cmbPartNumber.SelectedValue);
                hdSelected.StartDate = DateConvert.PersianToGregorian(txtStartDate.Text);
                hdSelected.EndDate = DateConvert.PersianToGregorian(txtEndDate.Text);
                hdSelected.IsTransferred = chkIsTransferred.Checked;
                db.HardwareIds.Update(hdSelected);
            }
            else
            {
                var hdNew = new HardwareId()
                {
                    MemberId = Convert.ToInt32(cmbPersonelCode.SelectedValue),
                    RegionId = Convert.ToInt32(cmbRegionName.SelectedValue),
                    PartId = Convert.ToInt32(cmbPartNumber.SelectedValue),
                    StartDate = DateConvert.PersianToGregorian(txtStartDate.Text),
                    EndDate = DateConvert.PersianToGregorian(txtEndDate.Text),
                    IsTransferred = true
                };
                db.HardwareIds.Add(hdNew);
            }

            if (db.SaveChanges() > 0)
                _listHardwareId.Reload();

            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
