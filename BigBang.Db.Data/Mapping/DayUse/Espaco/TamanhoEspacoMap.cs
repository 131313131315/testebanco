using Db.Domain.Entities.Cadastros.DayUse;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Db.Data.Mapping
{
    public class TamanhoEspacoMap : IEntityTypeConfiguration<TamanhoEspaco>
    {
        public void Configure(EntityTypeBuilder<TamanhoEspaco> builder)
        {
            builder.ToTable("park_TamanhoEspaco");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Descricao).IsRequired().HasMaxLength(30);
        }
    }
}
