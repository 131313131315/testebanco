using Db.Domain.Entities.Hotel.Hospede;
using Db.Domain.Entities.Hotel.Quartos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Db.Data.Mapping.Hotel.Quartos
{


    public class ConsumoQuartoMap : IEntityTypeConfiguration<ConsumoQuarto>
    {
        public void Configure(EntityTypeBuilder<ConsumoQuarto> builder)
        {
            builder.ToTable("hotel_ConsumoQuarto");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.ItemId).HasColumnName("IdItem");
            builder.Property(c => c.ReservaId).HasColumnName("IdReserva");
            builder.Property(c => c.UsuarioId).HasColumnName("IdUsuario");
            builder.Property(c => c.QuartoId).HasColumnName("IdQuarto");

        }
    }
}
