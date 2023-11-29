using Db.Domain.Entities.Cadastros.DayUse;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Db.Data.Mapping
{
    public class EspacoMap : IEntityTypeConfiguration<Espaco>
    {
        public void Configure(EntityTypeBuilder<Espaco> builder)
        {
            builder.ToTable("park_Espaco");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.TamanhoEspacoId).HasColumnName("IdTamanhoEspaco");
        }
    }
}
