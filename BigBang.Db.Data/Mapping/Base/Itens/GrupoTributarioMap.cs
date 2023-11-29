using Domain.Entities.Cadastros.Produto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Db.Data.Mapping.Itens
{
    public class GrupoTributarioMap
    {
        public void Configure(EntityTypeBuilder<GrupoTributario> builder)
        {
            builder.ToTable("base_GrupoTributario");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Descricao).IsRequired().HasMaxLength(100);
            builder.Property(c => c.CFOP).IsRequired().HasMaxLength(30);
            builder.Property(c => c.GeraFinanceiro).IsRequired();
            builder.Property(c => c.ConfiguracaoICMSId).IsRequired();
            builder.Property(c => c.ConfiguracaoIPIId).IsRequired();
            builder.Property(c => c.ConfiguracaoPisConfinsId).IsRequired();
            builder.Property(c => c.ConfiguracaoISSId).IsRequired();
            builder.Property(c => c.ConfiguracaoSubstituicaoTributariaId).IsRequired();
        }
    }
}
