using Domain.Entities.Cadastros.Produto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Db.Data.Mapping.Base
{


    public class ItemEntradaSaidaMap : IEntityTypeConfiguration<ItemEntradaSaida>
    {
        public void Configure(EntityTypeBuilder<ItemEntradaSaida> builder)
        {
            builder.ToTable("base_ItemEntradaSaida");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.ItemId).HasColumnName("IdItem");
            builder.Property(c => c.EmpresaId).HasColumnName("IdEmpresa");
        }
    }
}

