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
    public class MemberConfig : IEntityTypeConfiguration<Member>
    {
        public void Configure(EntityTypeBuilder<Member> builder)
        {
            builder.Property(a => a.FirstName).IsRequired().HasMaxLength(66);
            builder.Property(a => a.LastName).IsRequired().HasMaxLength(64);
            builder.Property(a => a.PersonelCode).IsRequired().HasMaxLength(16);
            builder.Property(a => a.Mobile).IsRequired().HasMaxLength(16);
            builder.Property(a => a.NationalCode).IsRequired().HasMaxLength(16);
            builder.Property(a => a.ImagePath).IsRequired().HasMaxLength(256);
        }
    }
}
