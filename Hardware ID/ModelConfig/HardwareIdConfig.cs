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
    public class HardwareIdConfig : IEntityTypeConfiguration<HardwareId>
    {
        public void Configure(EntityTypeBuilder<HardwareId> builder)
        {
        }
    }
}
