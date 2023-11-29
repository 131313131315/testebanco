using Db.Domain.Entities.DayUse.AutoAtendimento;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Db.Data.Mapping.DayUse.AutoAtendimento
{


    public class AutomacaoLogMap : IEntityTypeConfiguration<AutomacaoLog>
    {
        public void Configure(EntityTypeBuilder<AutomacaoLog> builder)
        {
            builder.ToTable("atm_AutomacaoLog");
            builder.HasKey(c => c.Id);

            //builder.HasMany(c => c.MovimentacaoCartoes).WithOne(c => c.Terminal).HasForeignKey(c => c.TerminalId);
        }
    }
}
