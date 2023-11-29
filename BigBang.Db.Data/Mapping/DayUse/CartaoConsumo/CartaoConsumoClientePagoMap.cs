
using Db.Domain.Entities.DayUse.CartaoConsumoPark;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Db.Data.Mapping.DayUse
{
    public class CartaoConsumoClientePagoMap : IEntityTypeConfiguration<CartaoConsumoClientePago>
    {
        public void Configure(EntityTypeBuilder<CartaoConsumoClientePago> builder)
        {
            builder.ToTable("park_CartaoConsumoClientePago");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.PessoaId).HasColumnName("IdPessoa");

        }
    }
}
