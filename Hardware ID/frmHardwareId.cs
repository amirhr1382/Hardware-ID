using Hardware_ID.DatabaseContext;
using Hardware_ID.Models;
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
        public bool update;
        public int hardwareId;

        public frmHardwareId()
        {
            InitializeComponent();

            Application.CurrentCulture = new CultureInfo("fa-IR");
            dateTimePicker1.CustomFormat = Application.CurrentCulture.DateTimeFormat.ShortDatePattern;
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBacke_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                /* if (update == false)
                    // shenasnameTableAdapter.InsertQuery(int.Parse(comboBox1.SelectedValue.ToString()), int.Parse(comboBoxNregion.SelectedValue.ToString()), int.Parse(comboBox2.SelectedValue.ToString()), txtSdata.Text, txtEdata.Text, checkBox1.Checked);
                 else
                    // shenasnameTableAdapter.UpdateQuery(int.Parse(comboBox1.SelectedValue.ToString()), int.Parse(comboBoxNregion.SelectedValue.ToString()), int.Parse(comboBox2.SelectedValue.ToString()), txtSdata.Text, txtEdata.Text, checkBox1.Checked, Row);
                */
                MessageBox.Show("ثبت اطلاعات با موفقیت انجام شد");
                this.Close();
            }
            catch
            {
                MessageBox.Show("ثبت اطلاعات با شکست مواجه شد", "خطا");
            }


        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
