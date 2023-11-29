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

    public class ReservaPacoteMap : IEntityTypeConfiguration<ReservaPacote>
    {
        public void Configure(EntityTypeBuilder<ReservaPacote> builder)
        {
            builder.ToTable("hotel_ReservaPacote");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.ReservaId).HasColumnName("IdReserva");
            builder.Property(c => c.PacoteId).HasColumnName("IdPacote");

        }
    }
}
