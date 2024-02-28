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
using System.Xml.Linq;

namespace Hardware_ID
{
    public partial class frmRegion : Form
    {
        public int regioId { get; set; }
        public listRegion _listRegion { get; set; }

        public frmRegion(listRegion listRegion)
        {
            InitializeComponent();
            _listRegion = listRegion;
        }

        private void frmRegion_Load(object sender, EventArgs e)
        {
            if (regioId != 0)
            {
                var db = DbContextSingleton.GetInstance();
                Models.Region regionSelected = db.Regions.Find(regioId);

                txtCode.Text = regionSelected.Code;
                txtName.Text = regionSelected.Name;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var db = DbContextSingleton.GetInstance();

            if (regioId != 0)
            {
                Models.Region regionSelected = db.Regions.Find(regioId);
                regionSelected.Name = txtName.Text;
                regionSelected.Code = txtCode.Text;
                db.Regions.Update(regionSelected);
            }
            else
            {
                var regionNew = new Models.Region()
                {
                    Name = txtName.Text,
                    Code = txtCode.Text,
                };
                db.Regions.Add(regionNew);
            }

            if (db.SaveChanges() > 0)
                _listRegion.Reload();

            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
