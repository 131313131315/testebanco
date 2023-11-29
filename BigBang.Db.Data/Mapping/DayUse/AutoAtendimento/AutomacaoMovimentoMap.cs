using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Db.Domain.Entities.DayUse.AutoAtendimento;

namespace Db.Data.Mapping.DayUse.AutoAtendimento
{
    public class AutomacaoMovimentoMap : IEntityTypeConfiguration<AutomacaoMovimento>
    {
        public void Configure(EntityTypeBuilder<AutomacaoMovimento> builder)
        {
            builder.ToTable("atm_AutomacaoMovimento");
            builder.HasKey(c => c.Id);
            //builder.Property(c => c.CartaoConsumoId).HasColumnName("IdCartaoConsumo");
        }
    }
}
