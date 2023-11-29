using Db.Domain.Entities.DayUse.Voucher;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Db.Data.Mapping.DayUse.Voucher
{

    public class VoucherPassaporteMap : IEntityTypeConfiguration<VoucherPassaporte>
    {
        public void Configure(EntityTypeBuilder<VoucherPassaporte> builder)
        {
            builder.ToTable("park_Voucher");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.UsuarioId).HasColumnName("IdUsuario");
        }
    }
}
