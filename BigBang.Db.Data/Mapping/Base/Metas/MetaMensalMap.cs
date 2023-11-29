using Db.Domain.Entities.Cadastros.Base.Metas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Db.Data.Mapping
{
    public class MetaMensalMap : IEntityTypeConfiguration<MetaMensal>
    {
        public void Configure(EntityTypeBuilder<MetaMensal> builder)
        {
            builder.ToTable("base_MetaMensal");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Ano).IsRequired().HasMaxLength(6);
            builder.Property(c => c.Mes).IsRequired().HasMaxLength(20);
            builder.Property(c => c.MetaId).HasColumnName("IdMetaPorcentagem");
            builder.Property(c => c.PontosMetaId).HasColumnName("IdPontosMeta");
        }
    }
}
