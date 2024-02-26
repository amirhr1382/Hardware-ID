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
    public class PartConfig:IEntityTypeConfiguration<Part>
    {
        public void Configure(EntityTypeBuilder<Part> builder)
        {
            builder.Property(a => a.Name).IsRequired().HasMaxLength(128);
            builder.Property(a => a.Model).IsRequired().HasMaxLength(128);
            builder.Property(a => a.Number).IsRequired().HasMaxLength(16);
        }
    }
}
