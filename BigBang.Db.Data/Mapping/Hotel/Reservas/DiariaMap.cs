using Db.Domain.Entities.Hotel.Quartos;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Db.Domain.Entities.Hotel.Reservas;

namespace Db.Data.Mapping.Hotel.Reservas
{
    public class DiariaMap : IEntityTypeConfiguration<Diaria>
    {
        public void Configure(EntityTypeBuilder<Diaria> builder)
        {
            builder.ToTable("hotel_ReservaDiaria");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.ReservaId).HasColumnName("IdReserva");
            builder.Property(c => c.UsuarioId).HasColumnName("IdUsuario");
            builder.Property(c => c.QuartoId).HasColumnName("IdQuarto");

        }
    }
}
