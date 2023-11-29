using Db.Domain.Entities.Cadastros.DayUse.Cartao;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Db.Data.Mapping.DayUse
{
    public class MovimentacaoCartaoProdutosMap : IEntityTypeConfiguration<MovimentacaoCartaoProdutos>
    {
        public void Configure(EntityTypeBuilder<MovimentacaoCartaoProdutos> builder)
        {
            builder.ToTable("park_MovimentacaoCartaoProdutos");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.MovimentacaoCartaoId).IsRequired().HasColumnName("IdMovimentacaoCartao");
            builder.Property(c => c.ItemId).IsRequired().HasColumnName("IdItem");
            builder.Property(c => c.UsuarioEstornoId).HasColumnName("IdUsuarioEstorno");
            builder.Property(c => c.UsuarioId).HasColumnName("IdUsuario");
            builder.Property(c => c.VendaBarId).HasColumnName("IdVendaBar");
        }
    }
}


