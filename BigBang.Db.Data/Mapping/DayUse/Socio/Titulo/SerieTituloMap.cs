using Db.Domain.Entities.Socio.Titulos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Db.Data.Mapping.DayUse
{
    public class SerieTituloMap : IEntityTypeConfiguration<SerieTitulo>
    {
        public void Configure(EntityTypeBuilder<SerieTitulo> builder)
        {
            builder.ToTable("socio_SerieTitulo");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Descricao).HasMaxLength(10);
        }
    }
}


