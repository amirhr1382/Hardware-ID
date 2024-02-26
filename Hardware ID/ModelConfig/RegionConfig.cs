using Hardware_ID.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hardware_ID.ModelConfig
{
    public class RegionConfig:IEntityTypeConfiguration<Region>
    {
        public void Configure(EntityTypeBuilder<Region> builder)
        {
            builder.Property(a => a.Name).IsRequired().HasMaxLength(128);
            builder.Property(a => a.Code).IsRequired().HasMaxLength(16);
        }
    }
}
