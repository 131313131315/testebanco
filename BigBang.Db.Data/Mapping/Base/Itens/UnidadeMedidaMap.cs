using Db.Domain.Entities.Base.Item;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Db.Data.Mapping.Itens
{
    class UnidadeMedidaMap
    {
        public void Configure(EntityTypeBuilder<UnidadeMedida> builder)
        {
            builder.ToTable("base_UnidadeMedida");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Descricao).IsRequired().HasMaxLength(100);
        }
    }
}
