using Db.Domain.Entities.Financeiro.CategoriaContas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Db.Data.Mapping
{
    public class DemonstrativoResultadoExercicioMap : IEntityTypeConfiguration<DemonstrativoResultadoExercicio>
    {
        public void Configure(EntityTypeBuilder<DemonstrativoResultadoExercicio> builder)
        {
            builder.ToTable("fin_DemonstrativoResultadoExercicio");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Descricao).IsRequired().HasMaxLength(60);
        }
    }
}

