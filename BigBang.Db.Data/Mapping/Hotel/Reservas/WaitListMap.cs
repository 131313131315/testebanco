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
    public class WaitListMap : IEntityTypeConfiguration<WaitList>
    {
        public void Configure(EntityTypeBuilder<WaitList> builder)
        {
            builder.ToTable("hotel_WaitList");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.CategoriaId).HasColumnName("IdCategoria");

        }
    }
}
