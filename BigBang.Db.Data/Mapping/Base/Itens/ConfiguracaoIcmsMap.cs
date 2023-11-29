using Domain.Entities.Cadastros.Produto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Db.Data.Mapping.Itens
{
    public class ConfiguracaoIcmsMap
    {
        public void Configure(EntityTypeBuilder<ConfiguracaoIcms> builder)
        {
            builder.ToTable("base_ConfiguracaoICMS");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.CalculaICMS).IsRequired();
            builder.Property(c => c.PercentualTributacaoICMS).IsRequired();
            builder.Property(c => c.CalculaICMSDifal).IsRequired();
            builder.Property(c => c.AplicaValorIPIBaseCalculo).IsRequired();
            builder.Property(c => c.ICMSDeferido).IsRequired();
            builder.Property(c => c.PercentualReducaoBase).IsRequired();
        }
    }
}
