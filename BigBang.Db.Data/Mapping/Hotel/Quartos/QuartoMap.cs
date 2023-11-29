using Db.Domain.Entities.Cadastros;
using Db.Domain.Entities.Hotel.Quartos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Db.Data.Mapping.Hotel.Quartos
{



    public class QuartoMap : IEntityTypeConfiguration<Quarto>
    {
        public void Configure(EntityTypeBuilder<Quarto> builder)
        {
            builder.ToTable("hotel_Quarto");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.CategoriaId).HasColumnName("IdCategoria");

        }
    }
}
