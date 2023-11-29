using Domain.Entities.Cadastros.Modulos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Db.Data.Mapping
{
    public class ModulosMap : IEntityTypeConfiguration<Modulos>
    {
        public void Configure(EntityTypeBuilder<Modulos> builder)
        {
            builder.ToTable("base_ModulosSistema");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Descricao).IsRequired().HasMaxLength(30);
        }
    }
}
