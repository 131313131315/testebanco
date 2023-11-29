using Db.Domain.Entities.DayUse.VendaBar;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Db.Data.Mapping.DayUse
{
    public class VendaBarMap : IEntityTypeConfiguration<VendaBar>
    {
        public void Configure(EntityTypeBuilder<VendaBar> builder)
        {
            builder.ToTable("park_VendaBar");
            builder.HasKey(c => c.Id);            
            builder.Property(c => c.Observacao).HasMaxLength(90);
        }
    }
}
