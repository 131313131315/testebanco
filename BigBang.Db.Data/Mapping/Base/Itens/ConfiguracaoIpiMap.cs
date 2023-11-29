using Domain.Entities.Cadastros.Produto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Db.Data.Mapping.Itens
{
    public class ConfiguracaoIpiMap
    {
        public void Configure(EntityTypeBuilder<ConfiguracaoIpi> builder)
        {
            builder.ToTable("base_ConfiguracaoIPI");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.CalculaIPI).IsRequired();
            builder.Property(c => c.SituacaoTributariaIPI).IsRequired().HasMaxLength(60);
            builder.Property(c => c.PercentualReducaoIPI).IsRequired();
        }
    }
}
