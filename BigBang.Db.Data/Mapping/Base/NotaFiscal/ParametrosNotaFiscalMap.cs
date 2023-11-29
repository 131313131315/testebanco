using Db.Domain.Entities.Base.NotaFiscal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Db.Data.Mapping
{
    public class ParametrosNotaFiscalMap : IEntityTypeConfiguration<ParametrosNotaFiscal>
    {
        public void Configure(EntityTypeBuilder<ParametrosNotaFiscal> builder)
        {
            builder.ToTable("base_ParametrosNotaFiscal");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.WebServiceUf).HasMaxLength(5);
            builder.Property(c => c.FusoHorario).HasMaxLength(10);
        }
    }
}

