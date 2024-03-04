using Hardware_ID;
using Hardware_ID;
using Hardware_ID.DatabaseContext;
using Hardware_ID.ModelConfig;
using Hardware_ID.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hardware_ID.DatabaseContext
{
    public class HdDbContext : DbContext
    {
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Part> Parts { get; set; }
        public DbSet<HardwareId> HardwareIds { get; set; }

        #region Required
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AdminConfig());
            modelBuilder.ApplyConfiguration(new MemberConfig());
            modelBuilder.ApplyConfiguration(new RegionConfig());
            modelBuilder.ApplyConfiguration(new PartConfig());
            modelBuilder.ApplyConfiguration(new HardwareIdConfig());
        }
        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseSqlServer("Data Source=localhost;" +
                                           "Initial Catalog=HardwareIdDb;" +
                                           "User Id=admin;" +
                                           "password=1234;" +
                                           "Trusted_Connection=True;" +
                                           "TrustServerCertificate=True;");
    }
}
