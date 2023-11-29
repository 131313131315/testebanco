using Domain.Entities.Cadastros.Produto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Db.Data.Mapping.Itens
{
    public class ConfiguracaoIssMap
    {
        public void Configure(EntityTypeBuilder<ConfiguracaoIss> builder)
        {
            builder.ToTable("base_ConfiguracaoISS");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.CalculaISS).IsRequired();
            builder.Property(c => c.RetencaoISS).IsRequired();
            builder.Property(c => c.PercentualReducaoISS).IsRequired();
            builder.Property(c => c.SituacaoTributariaISS).IsRequired().HasMaxLength(60);
        }
    }
}
