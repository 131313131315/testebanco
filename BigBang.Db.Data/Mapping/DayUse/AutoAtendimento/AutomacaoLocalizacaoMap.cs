

using Db.Domain.Entities.DayUse.AutoAtendimento;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Db.Data.Mapping.DayUse
{
    public class AutomacaoLocalizacaoMap : IEntityTypeConfiguration<AutomacaoLocalizacao>
    {
        public void Configure(EntityTypeBuilder<AutomacaoLocalizacao> builder)
        {
            builder.ToTable("atm_AutomacaoLocalizacao");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.AutomacaoConfiguracaoId).HasColumnName("AutomacaoConfiguracaoId");            
        }
    }

}
