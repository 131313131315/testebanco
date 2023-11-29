using Db.Domain.Entities.DayUse.TEF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Db.Data.Mapping.Base
{
    public class ConfiguracaoTefMap : IEntityTypeConfiguration<ConfiguracaoTef>
    {
        public void Configure(EntityTypeBuilder<ConfiguracaoTef> builder)
        {
            builder.ToTable("base_ConfiguracaoTef");
            builder.HasKey(c => c.Id);
            builder.HasMany(c => c.Terminais).WithOne(c => c.ConfiguracaoTef).HasForeignKey(c => c.ConfiguracaoTefId);
        }
    }

    public class TerminaisTefMap : IEntityTypeConfiguration<TerminaisTef>
    {
        public void Configure(EntityTypeBuilder<TerminaisTef> builder)
        {
            builder.ToTable("base_TerminaisTef");
            builder.HasKey(c => c.Id);

            //builder.HasMany(c => c.MovimentacaoCartoes).WithOne(c => c.Terminal).HasForeignKey(c => c.TerminalId);
        }
    }
}
