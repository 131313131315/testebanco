using Domain.Entities.Cadastros.Produto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Db.Data.Mapping.Itens
{
    public class ConfiguracaoSubstituicaoTributariaMap
    {
        public void Configure(EntityTypeBuilder<ConfiguracaoSubstituicaoTributaria> builder)
        {
            builder.ToTable("base_ConfiguracaoSubstituicaoTributaria");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.CalculaSubstituicaoTributaria).IsRequired();
            builder.Property(c => c.PercentualReducaoSubstituicaoTributaria).IsRequired();
            builder.Property(c => c.AplicaIPIBaseCalculo).IsRequired();
            builder.Property(c => c.AplicaPisConfinsBaseCalculo).IsRequired();
        }
    }
}
