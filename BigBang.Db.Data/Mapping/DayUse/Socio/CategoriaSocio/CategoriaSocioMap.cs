using Db.Domain.Entities.Cadastros.Socio.CategoriaSocio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Db.Data.Mapping.DayUse.Socio
{
    public class CategoriaSocioMap : IEntityTypeConfiguration<CategoriaSocio>
    {
        public void Configure(EntityTypeBuilder<CategoriaSocio> builder)
        {
            builder.ToTable("socio_CategoriaSocio");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Descricao).IsRequired().HasMaxLength(50);
        }
    }
}
