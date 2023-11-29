using Db.Domain.Entities.DayUse.Passaportes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Db.Data.Mapping.DayUse.Passaportes
{
    public class PassaporteLogMap : IEntityTypeConfiguration<PassaporteLog>
    {
        public void Configure(EntityTypeBuilder<PassaporteLog> builder)
        {
            builder.ToTable("park_PassaporteLog");
            builder.HasKey(c => c.Id);
        }
    }
}
