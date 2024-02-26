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
    public partial class frmPart : Form
    {
        public int partId;
        public listPart _listPart;

        public frmPart(listPart listPart)
        {
            InitializeComponent();
            _listPart = listPart;
        }

        private void frmPart_Load(object sender, EventArgs e)
        {
            if (partId != 0)
            {
                var db = DbContextSingleton.GetInstance();
                Part partSelected = db.Parts.Find(partId);

                txtName.Text = partSelected.Name;
                txtModel.Text = partSelected.Model;
                txtNumber.Text = partSelected.Number;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var db = DbContextSingleton.GetInstance();

            if (partId != 0)
            {
                Part partSelected = db.Parts.Find(partId);
                partSelected.Name = txtName.Text;
                partSelected.Model = txtModel.Text;
                partSelected.Number = txtNumber.Text;
                db.Parts.Update(partSelected);
            }
            else
            {
                var partNew = new Part()
                {
                    Name = txtName.Text,
                    Model = txtModel.Text,
                    Number = txtNumber.Text
                };
                db.Parts.Add(partNew);
            }

            if (db.SaveChanges() > 0)
                _listPart.Reload();

            this.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
