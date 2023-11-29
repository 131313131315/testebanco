using Domain.Entities.Cadastros.Produto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Db.Data.Mapping.Itens
{
    public class ConfiguracaoPisConfinsMap
    {
        public void Configure(EntityTypeBuilder<ConfiguracaoPisConfins> builder)
        {
            builder.ToTable("base_ConfiguracaoPisConfins");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.CalculaPisConfins).IsRequired();
            builder.Property(c => c.SituacaoTributariaPisConfins).IsRequired().HasMaxLength(60);
            builder.Property(c => c.RetencaoPis).IsRequired();
            builder.Property(c => c.RetencaoConfins).IsRequired();
            builder.Property(c => c.PercentualReducaoConfins).IsRequired();
            builder.Property(c => c.PercentualReducaoPis).IsRequired();
            builder.Property(c => c.AplicaIPIBaseCalculo).IsRequired();
        }
    }
}
