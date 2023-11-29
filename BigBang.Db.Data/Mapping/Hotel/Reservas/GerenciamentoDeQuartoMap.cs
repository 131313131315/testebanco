using Db.Domain.Entities.Hotel.Reservas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Db.Data.Mapping.Hotel.Reservas
{
    public class GerenciamentoDeQuartoMap : IEntityTypeConfiguration<GerenciamentoDeQuarto>
    {
        public void Configure(EntityTypeBuilder<GerenciamentoDeQuarto> builder)
        {
            builder.ToTable("hotel_GerenciamentoQuarto");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.ReservaId).HasColumnName("IdReserva");
            builder.Property(c => c.QuartoId).HasColumnName("IdQuarto");
            

        }
    }
}
