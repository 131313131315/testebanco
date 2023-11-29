using Db.Domain.Entities.DayUse;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Db.Data.Mapping.DayUse
{
    public class ExcursaoPassaporteMap : IEntityTypeConfiguration<ExcursaoPassaporte>
    {
        public void Configure(EntityTypeBuilder<ExcursaoPassaporte> builder)
        {
            builder.ToTable("park_ExcursaoPassaporte");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.ExcursaoId).IsRequired().HasColumnName("IdExcursao");
            builder.Property(c => c.PacotePassaporteId).HasColumnName("IdPacotePassaporte");

            


        }
    }
}

