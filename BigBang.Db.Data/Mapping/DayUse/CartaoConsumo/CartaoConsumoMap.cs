using Db.Domain.Entities.Cadastros.DayUse.Cartao;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Db.Data.Mapping.DayUse
{
    public class CartaoConsumoMap : IEntityTypeConfiguration<CartaoConsumo>
    {
        public void Configure(EntityTypeBuilder<CartaoConsumo> builder)
        {
            builder.ToTable("park_CartaoConsumo");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Numero).IsRequired().HasMaxLength(50);
            builder.Property(c => c.EmpresaCartaoRetidoId).HasColumnName("IdEmpresaCartaoRetido");
        }
    }
}

