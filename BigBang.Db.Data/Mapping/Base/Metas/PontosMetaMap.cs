using Db.Domain.Entities.Cadastros.Base.Metas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Db.Data.Mapping
{
    public class PontosMetaMap : IEntityTypeConfiguration<PontosMeta>
    {
        public void Configure(EntityTypeBuilder<PontosMeta> builder)
        {
            builder.ToTable("base_PontosMeta");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Ano).IsRequired().HasMaxLength(6);
        }
    }
}