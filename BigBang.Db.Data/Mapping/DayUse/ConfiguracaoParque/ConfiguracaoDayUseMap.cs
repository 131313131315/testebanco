using Db.Domain.Entities.Cadastros.Base.Configuracao;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Db.Data.Mapping.DayUse
{
    public class ConfiguracaoDayUseMap : IEntityTypeConfiguration<ConfiguracaoDayUse>
    {
        public void Configure(EntityTypeBuilder<ConfiguracaoDayUse> builder)
        {
            builder.ToTable("park_Configuracao");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Nome).IsRequired().HasMaxLength(50);
            builder.Property(c => c.Descricao).IsRequired().HasMaxLength(50);
            builder.Property(c => c.Valor).IsRequired();
        }
    }
}

