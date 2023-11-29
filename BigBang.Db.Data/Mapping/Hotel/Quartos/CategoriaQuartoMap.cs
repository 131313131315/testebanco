using Db.Domain.Entities.Cadastros;
using Db.Domain.Entities.Hotel.Hospede;
using Db.Domain.Entities.Hotel.Quartos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Db.Data.Mapping.Hotel.Quartos
{


    public class CategoriaQuartoMap : IEntityTypeConfiguration<Categoria>
    {
        public void Configure(EntityTypeBuilder<Categoria> builder)
        {
            builder.ToTable("hotel_CategoriaQuarto");
            builder.HasKey(c => c.Id);            

        }
    }
}
