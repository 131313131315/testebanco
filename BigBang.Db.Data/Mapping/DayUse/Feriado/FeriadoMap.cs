using Db.Domain.Entities.Cadastros.DayUse;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Db.Data.Mapping.DayUse
{
    public class FeriadoMap : IEntityTypeConfiguration<Feriado>
    {
        public void Configure(EntityTypeBuilder<Feriado> builder)
        {
            builder.ToTable("park_Feriados");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Descricao).IsRequired().HasMaxLength(30);
        }
    }
}
