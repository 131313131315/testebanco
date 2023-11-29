using Db.Domain.Entities.Cadastros.DayUse;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Db.Data.Mapping.DayUse
{
    public class CatracaMap : IEntityTypeConfiguration<Catraca>
    {
        public void Configure(EntityTypeBuilder<Catraca> builder)
        {
            builder.ToTable("park_Catraca");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Descricao).IsRequired().HasMaxLength(70);
            builder.Property(c => c.Ip).IsRequired().HasMaxLength(50);
        }
    }
}
