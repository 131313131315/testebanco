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


    public class RefeicaoPrecoMap : IEntityTypeConfiguration<RefeicaoPreco>
    {
        public void Configure(EntityTypeBuilder<RefeicaoPreco> builder)
        {
            builder.ToTable("hotel_RefeicaoPreco");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.RefeicaoId).HasColumnName("IdRefeicao");

        }
    }
}
