using Db.Domain.Entities.DayUse.Log;
using Db.Domain.Entities.DayUse.Passaportes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Db.Data.Mapping.DayUse.Passaportes
{
    public class LogDayUserMap : IEntityTypeConfiguration<LogDayUser>
    {
        public void Configure(EntityTypeBuilder<LogDayUser> builder)
        {
            builder.ToTable("park_LogDayUser");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.EmpresaId).HasColumnName("IdEmpresa");
        }
    }
}

