using Db.Domain.Entities.Socio.SocioCobranca;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Db.Data.Mapping.DayUse
{
    public class SocioCobrancaMap : IEntityTypeConfiguration<SocioCobranca>
    {
        public void Configure(EntityTypeBuilder<SocioCobranca> builder)
        {
            builder.ToTable("socio_SocioCobranca");
            builder.HasKey(c => c.Id);
        }
    }
}
