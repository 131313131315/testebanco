using Db.Domain.Entities.Cadastros.Base.Metas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Db.Data.Mapping
{
    public class MetaPorcentagemMap : IEntityTypeConfiguration<MetaPorcentagem>
    {
        public void Configure(EntityTypeBuilder<MetaPorcentagem> builder)
        {
            builder.ToTable("base_MetaPorcentagem");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Descricao).IsRequired().HasMaxLength(30);
        }
    }
}