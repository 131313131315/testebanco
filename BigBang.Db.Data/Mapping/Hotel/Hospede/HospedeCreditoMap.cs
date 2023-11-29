

using Db.Domain.Entities.Hotel.Hospede;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Db.Data.Mapping.Hotel.Hospede
{

    public class HospedeCreditoMap : IEntityTypeConfiguration<HospedeCredito>
    {
        public void Configure(EntityTypeBuilder<HospedeCredito> builder)
        {
            builder.ToTable("hotel_HospedeCredito");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.TitularId).HasColumnName("IdTitular");

        }
    }
}
