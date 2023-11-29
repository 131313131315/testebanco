using Db.Domain.Entities.Financeiro.Boleto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Db.Data.Mapping
{
    public class BoletoMap : IEntityTypeConfiguration<Boletos>
    {
        public void Configure(EntityTypeBuilder<Boletos> builder)
        {
            builder.ToTable("fin_Boleto");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.CodigoBeneficiario).HasMaxLength(50);
            builder.Property(c => c.NossoNumero).HasMaxLength(50);
            builder.Property(c => c.NumeroDocumento).HasMaxLength(50);
        }
    }
}
