
using Db.Domain.Entities.Hotel.Hospede;
using Db.Domain.Entities.Hotel.Pacotes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Db.Data.Mapping.Hotel.Pacotes
{


    public class PacoteMensalMap : IEntityTypeConfiguration<PacoteMensal>
    {
        public void Configure(EntityTypeBuilder<PacoteMensal> builder)
        {
            builder.ToTable("hotel_PacoteMensal");
            builder.HasKey(c => c.Id);

        }
    }
}
