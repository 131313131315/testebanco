using Domain.Entities.Cadastros.Produto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Db.Data.Mapping
{
    public class ItemMap
    {
        public void Configure(EntityTypeBuilder<produto> builder)
        {
            builder.ToTable("base_Item");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Descricao).HasMaxLength(100);
            builder.Property(c => c.GTIN).HasMaxLength(30);
            builder.Property(c => c.ValorUnitario).IsRequired().HasMaxLength(20);
            builder.Property(c => c.NCM).HasMaxLength(30);
            builder.Property(c => c.Cest).HasMaxLength(30);           
            builder.Property(c => c.TipoItem).IsRequired();
            builder.Property(c => c.UnidadeId).HasColumnName("IdUnidade");
            builder.Property(c => c.DepartamentoId).HasColumnName("IdDepartamento");
            //builder.Property(c => c.ControlarEstoque).HasDefaultValue(false);
            builder.Property(c => c.Iss).HasDefaultValue(0);
            builder.Property(c => c.Ativo).HasDefaultValue(false);
        }
    }
}
