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


    public class ReservaReembolsoMap : IEntityTypeConfiguration<ReservaReembolso>
    {
        public void Configure(EntityTypeBuilder<ReservaReembolso> builder)
        {
            builder.ToTable("hotel_ReservaReembolso");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.TitularId).HasColumnName("IdTitular");
            builder.Property(c => c.ReservaId).HasColumnName("IdReserva");
            builder.Property(c => c.UsuarioId).HasColumnName("IdUsuario");

        }
    }
}
