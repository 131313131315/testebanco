using Db.Domain.Entities.DayUse;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Db.Data.Mapping.DayUse
{
    public class ExcursaoProdutosMap : IEntityTypeConfiguration<ExcursaoProdutos>
    {
        public void Configure(EntityTypeBuilder<ExcursaoProdutos> builder)
        {
            builder.ToTable("park_ExcursaoProdutos");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.ExcursaoId).IsRequired().HasColumnName("IdExcursao");
            builder.Property(c => c.ProdutoId).IsRequired().HasColumnName("IdProduto");
        }
    }
}


