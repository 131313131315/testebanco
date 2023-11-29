using Db.Domain.Entities.Financeiro.Cheques;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Db.Data.Mapping
{
    public class ControleChequeMap : IEntityTypeConfiguration<ControleCheque>
    {
        public void Configure(EntityTypeBuilder<ControleCheque> builder)
        {
            builder.ToTable("fin_ControleChequeMap");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Destinatario).HasMaxLength(100);
            builder.Property(c => c.NomeEmitente).HasMaxLength(100);
            builder.Property(c => c.Referente).HasMaxLength(50);
            builder.Property(c => c.NumeroCheque).HasMaxLength(50);
        }
    }
}
