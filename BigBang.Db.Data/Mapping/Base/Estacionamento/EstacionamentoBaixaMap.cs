using Db.Domain.Entities.Base.Estacionamento;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Db.Data.Mapping.Base.Estacionamento
{
    public class EstacionamentoBaixaMap : IEntityTypeConfiguration<EstacionamentoBaixa>
    {
        public void Configure(EntityTypeBuilder<EstacionamentoBaixa> builder)
        {
            builder.ToTable("base_EstacionamentoBaixa");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Carteirinha).HasMaxLength(80);
            builder.Property(c => c.Cota).HasMaxLength(80);
            builder.Property(c => c.NumeroTicket).HasMaxLength(80);
        }
    }
}
