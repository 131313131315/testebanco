using Db.Domain.Entities.Cadastros;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Db.Data.Mapping
{
    public class CategoriaContasMap : IEntityTypeConfiguration<CategoriaContas>
    {
        public void Configure(EntityTypeBuilder<CategoriaContas> builder)
        {
            builder.ToTable("fin_CategoriaContas");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Descricao).IsRequired().HasMaxLength(60);
            builder.Property(c => c.Natureza).IsRequired();
            builder.Property(c => c.IdEmpresa).IsRequired();
        }
    }
}
