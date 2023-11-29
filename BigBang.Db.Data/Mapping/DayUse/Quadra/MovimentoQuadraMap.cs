using Db.Domain.Entities.Base.Quadra;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Db.Data.Mapping.DayUse.Quadra
{
    public class MovimentoQuadraMap
    {
        public void Configure(EntityTypeBuilder<MovimentoQuadra> builder)
        {
            builder.ToTable("quadra_Movimento");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.HorarioId).HasColumnName("IdHorario");
        }
    }
}
