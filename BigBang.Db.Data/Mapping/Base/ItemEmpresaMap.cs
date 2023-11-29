using Domain.Entities.Cadastros.Produto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Db.Data.Mapping
{

    public class ItemEmpresaMap : IEntityTypeConfiguration<ItemEmpresa>
    {
        public void Configure(EntityTypeBuilder<ItemEmpresa> builder)
        {
            builder.ToTable("base_ItemEmpresa");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.EmpresaId).HasColumnName("IdEmpresa");
            builder.Property(c => c.ItemId).HasColumnName("IdItem");
            builder.Property(c => c.NomeImpressora).HasMaxLength(30);
            builder.Property(c => c.Ativo).HasDefaultValue(false);
        }
    }


}
