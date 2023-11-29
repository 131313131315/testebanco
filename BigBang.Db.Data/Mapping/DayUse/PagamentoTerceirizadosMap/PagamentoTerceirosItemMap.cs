


using Db.Domain.Entities.DayUse.PagamentoTerceirizados;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Db.Data.Mapping.DayUse
{
    public class PagamentoTerceirosItemMap : IEntityTypeConfiguration<PagamentoTerceirosItem>
    {
        public void Configure(EntityTypeBuilder<PagamentoTerceirosItem> builder)
        {
            builder.ToTable("park_PagamentoTerceirosItem");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.PagamentoTerceiroId).IsRequired().HasColumnName("IdPagamentoTerceiro");
            builder.Property(c => c.ProdutoId).IsRequired().HasColumnName("IdProduto");
            builder.Property(c => c.EmpresaId).IsRequired().HasColumnName("IdEmpresa");
            builder.Property(c => c.UsuarioId).HasColumnName("IdUsuario");
        }
    }
}

