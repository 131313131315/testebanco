using Db.Domain.Entities.Cadastros.DayUse.Cartao;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Db.Data.Mapping.DayUse
{
    public class MovimentacaoCartaoConsumoMap : IEntityTypeConfiguration<MovimentacaoCartaoConsumo>
    {
        public void Configure(EntityTypeBuilder<MovimentacaoCartaoConsumo> builder)
        {
            builder.ToTable("park_MovimentacaoCartaoConsumo");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.NumeroComprovante).IsRequired().HasMaxLength(30);            
        }
    }
}

