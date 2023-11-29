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



    public class ValorQuadraMap
    {
        public void Configure(EntityTypeBuilder<ValorQuadra> builder)
        {
            builder.ToTable("quadra_Valor");
            builder.HasKey(c => c.Id);
        }
    }
}
