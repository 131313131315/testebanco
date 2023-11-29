using Db.Domain.Entities.Cadastros.DayUse.PassaportePacote;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Db.Data.Mapping.DayUse
{
    public class PassaportePacoteMap : IEntityTypeConfiguration<PassaportePacote>
    {
        public void Configure(EntityTypeBuilder<PassaportePacote> builder)
        {
            builder.ToTable("park_ExcursaoValor");
            builder.HasKey(c => c.Id);           
            builder.Property(c => c.Descricao).IsRequired().HasMaxLength(100);
        }
    }
}
