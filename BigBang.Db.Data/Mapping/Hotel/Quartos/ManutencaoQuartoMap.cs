using Db.Domain.Entities.Hotel.Quartos;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Db.Data.Mapping.Hotel.Quartos
{

    public class ManutencaoQuartoMap : IEntityTypeConfiguration<ManutencaoQuarto>
    {
        public void Configure(EntityTypeBuilder<ManutencaoQuarto> builder)
        {
            builder.ToTable("hotel_ManutencaoQuarto");
            builder.HasKey(c => c.Id);
        }
    }
}
