using Db.Domain.Entities.Socio.Titulos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Db.Data.Mapping.DayUse
{
    public class TituloSociosMap : IEntityTypeConfiguration<TituloSocios>
    {
        public void Configure(EntityTypeBuilder<TituloSocios> builder)
        {
            builder.ToTable("socio_TituloSocios");
            builder.HasKey(c => c.Id);
        }
    }
}

