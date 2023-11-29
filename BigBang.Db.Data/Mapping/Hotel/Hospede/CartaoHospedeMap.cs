using Db.Domain.Entities.Hotel.Hospede;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Db.Data.Mapping.Hotel.Hospede
{


    public class CartaoHospedeMap : IEntityTypeConfiguration<CartaoHospede>
    {
        public void Configure(EntityTypeBuilder<CartaoHospede> builder)
        {
            builder.ToTable("hotel_CartaoHospede");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.ReservaId).HasColumnName("IdReserva");
            builder.Property(c => c.CartaoConsumoId).HasColumnName("IdCartaoConsumo");
            builder.Property(c => c.HospedeId).HasColumnName("IdHospede");

        }
    }
}
