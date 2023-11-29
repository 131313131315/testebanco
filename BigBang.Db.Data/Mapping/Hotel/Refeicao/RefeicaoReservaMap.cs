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


    public class RefeicaoReservaMap : IEntityTypeConfiguration<RefeicaoReserva>
    {
        public void Configure(EntityTypeBuilder<RefeicaoReserva> builder)
        {
            builder.ToTable("hotel_Refeicao");
            builder.HasKey(c => c.Id);            

        }
    }
}
