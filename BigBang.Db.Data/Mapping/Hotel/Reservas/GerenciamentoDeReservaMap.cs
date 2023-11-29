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
    public class GerenciamentoDeReservaMap : IEntityTypeConfiguration<GerenciamentoDeReserva>
    {
        public void Configure(EntityTypeBuilder<GerenciamentoDeReserva> builder)
        {
            builder.ToTable("hotel_GerenciamentoReserva");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.ReservaId).HasColumnName("IdReserva");
            builder.Property(c => c.QuartoId).HasColumnName("IdQuarto");
            builder.Property(c => c.HospedeId).HasColumnName("IdHospede");

        }
    }
}
