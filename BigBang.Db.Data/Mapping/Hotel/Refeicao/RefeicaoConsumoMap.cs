using Db.Domain.Entities.Hotel.Quartos;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Db.Domain.Entities.Hotel.Refeicao;

namespace Db.Data.Mapping.Hotel.Refeicao
{

    public class RefeicaoConsumoMap : IEntityTypeConfiguration<RefeicaoConsumo>
    {
        public void Configure(EntityTypeBuilder<RefeicaoConsumo> builder)
        {
            builder.ToTable("hotel_RefeicaoConsumo");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.ReservaId).HasColumnName("IdReserva");
            builder.Property(c => c.QuartoId).HasColumnName("IdQuarto");
            builder.Property(c => c.HospedeId).HasColumnName("IdHospede");
            builder.Property(c => c.RefeicaoPrecoId).HasColumnName("IdRefeicaoPreco");

        }
    }
}
