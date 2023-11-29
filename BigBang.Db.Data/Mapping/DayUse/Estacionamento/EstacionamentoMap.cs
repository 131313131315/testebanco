using Db.Domain.Entities.Cadastros.DayUse.Estacionamento;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Db.Data.Mapping.DayUse
{
    public class EstacionamentoSocioMap : IEntityTypeConfiguration<EstacionamentoSocio>
    {
        public void Configure(EntityTypeBuilder<EstacionamentoSocio> builder)
        {
            builder.ToTable("park_EstacionamentoSocio");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Titulo).IsRequired().HasMaxLength(50);
        }
    }
}
