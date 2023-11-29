using Db.Domain.Entities.Cadastros.DayUse;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Db.Data.Mapping
{
    public class ArmarioMap : IEntityTypeConfiguration<Armario>
    {
        public void Configure(EntityTypeBuilder<Armario> builder)
        {
            builder.ToTable("park_Armario");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.CartaoConsumoId).HasColumnName("IdCartaoConsumo");            
        }
    }
}
