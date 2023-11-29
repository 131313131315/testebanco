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

    public class QuartoStandbyMap : IEntityTypeConfiguration<QuartoStandby>
    {
        public void Configure(EntityTypeBuilder<QuartoStandby> builder)
        {
            builder.ToTable("hotel_quarto_standby");
            builder.HasKey(c => c.Id);            

        }
    }
}
