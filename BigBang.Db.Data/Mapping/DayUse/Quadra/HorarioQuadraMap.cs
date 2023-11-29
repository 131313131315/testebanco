using Db.Domain.Entities.Base.Quadra;
using Db.Domain.Entities.Cadastros.DayUse.Passaportes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Db.Data.Mapping.DayUse.Quadra
{
    public class HorarioQuadraMap
    {
        public void Configure(EntityTypeBuilder<HorarioQuadra> builder)
        {
            builder.ToTable("quadra_Horario");
            builder.HasKey(c => c.Id);
        }
    }
}
