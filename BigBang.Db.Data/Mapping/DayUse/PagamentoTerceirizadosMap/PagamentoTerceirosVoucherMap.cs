using Db.Domain.Entities.DayUse.PagamentoTerceirizados;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Db.Data.Mapping.DayUse
{
    public class PagamentoTerceirosVoucherMap : IEntityTypeConfiguration<PagamentoTerceirosVoucher>
    {
        public void Configure(EntityTypeBuilder<PagamentoTerceirosVoucher> builder)
        {
            builder.ToTable("park_PagamentoTerceirosVoucher");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.EmpresaId).IsRequired().HasColumnName("IdEmpresa");
            builder.Property(c => c.ProdutoId).IsRequired().HasColumnName("IdProduto");
            builder.Property(c => c.PagamentoTerceiroId).HasColumnName("IdPagamentoTerceiros");
            builder.Property(c => c.ExcursaoId).IsRequired().HasColumnName("IdExcursao");
        }
    }
}
