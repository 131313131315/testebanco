using Db.Domain.Entities.Cadastros.DayUse;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Db.Data.Mapping.DayUse
{
    public class PassaportePromocaoMap : IEntityTypeConfiguration<PassaportePromocao>
    {
        public void Configure(EntityTypeBuilder<PassaportePromocao> builder)
        {
            builder.ToTable("park_PassaportePromocao");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Descricao).IsRequired().HasMaxLength(100);
        }
    }
}
