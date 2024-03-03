using Hardware_ID.DatabaseContext;
using Hardware_ID.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hardware_ID
{
    public class Globals
    {
        public string username;

    }
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Update database automatically
            var db = DbContextSingleton.GetInstance();
            db.Database.Migrate();

            if (!db.Admins.Any(a => a.IsMainAdmin))
            {
                db.Admins.Add(new Admin()
                {
                    FirstName = "مدیر سیستم",
                    LastName = string.Empty,
                    NationalCode = string.Empty,
                    Username = "admin",
                    Password = "admin",
                    PersonelCode = string.Empty,
                    ImagePath = string.Empty,
                    IsMainAdmin = true,
                });

                db.SaveChanges();
            }

            Application.Run(new Login());
        }
    }
}
