using Domain.Entities.Cadastros.Produto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Db.Data.Mapping
{
    public class GrupoItemMap
    {
        public void Configure(EntityTypeBuilder<GrupoItem> builder)
        {
            builder.ToTable("base_GrupoItem");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Descricao).IsRequired().HasMaxLength(100);
        }
    }
}
