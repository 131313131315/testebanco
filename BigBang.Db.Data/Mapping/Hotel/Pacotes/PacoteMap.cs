using Db.Domain.Entities.Hotel.Pacotes;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Db.Data.Mapping.Hotel.Pacotes
{


    public class PacoteMap : IEntityTypeConfiguration<Pacote>
    {
        public void Configure(EntityTypeBuilder<Pacote> builder)
        {
            builder.ToTable("hotel_Pacote");
            builder.HasKey(c => c.Id);

        }
    }
}
