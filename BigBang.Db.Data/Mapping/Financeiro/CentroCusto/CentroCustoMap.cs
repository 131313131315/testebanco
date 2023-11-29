using Db.Domain.Entities.Cadastros;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Db.Data.Mapping
{
    public class CentroCustoMap : IEntityTypeConfiguration<CentroCusto>
    {
        public void Configure(EntityTypeBuilder<CentroCusto> builder)
        {
            builder.ToTable("fin_CentroCusto");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Descricao).IsRequired().HasMaxLength(60);
            builder.Property(c => c.EmpresaId).HasColumnName("IdEmpresa");
        }
    }
}

