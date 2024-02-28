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
    public partial class listSearch : Form
    {
        public frmSearch _frmSearch { get; set; }

        public listSearch(frmSearch frmSearch)
        {
            InitializeComponent();
            _frmSearch = frmSearch;
        }

        private void listSearch_Load(object sender, EventArgs e)
        {
            var db = DbContextSingleton.GetInstance();
            db.Database.EnsureCreated();
            db.HardwareIds.Load();

            List<HardwareId> hardwareIds = db.HardwareIds.Where(h =>
                (h.Member.FirstName + " " + h.Member.LastName).Contains(_frmSearch.txtMemberName.Text) &&
                (h.Member.PersonelCode).Contains(_frmSearch.txtMemberPersonelCode.Text) &&
                (h.Part.Name).Contains(_frmSearch.txtPartName.Text) &&
                (h.Part.Number).Contains(_frmSearch.txtPartNumber.Text) &&
                (h.Region.Name).Contains(_frmSearch.txtRegion.Text)
            ).Include(q => q.Member)
            .Include(q => q.Part)
            .Include(q => q.Region)
            .ToList();

            this.searchViewModelBindingSource.DataSource = SearchViewModel.ListView(hardwareIds);
        }
    }
}
