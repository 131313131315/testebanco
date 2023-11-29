using Db.Domain.Entities.DayUse.PagamentoTerceirizados;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Db.Data.Mapping.DayUse
{
    public class PagamentoTerceirosMap : IEntityTypeConfiguration<PagamentoTerceiro>
    {
        public void Configure(EntityTypeBuilder<PagamentoTerceiro> builder)
        {
            builder.ToTable("park_PagamentoTerceiro");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.EmpresaId).IsRequired().HasColumnName("IdEmpresa");
        }
    }
}
