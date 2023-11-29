using Domain.Entities.Cadastros.Modulos;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities.Cadastros.Empresa;

namespace Db.Data.Mapping.Base
{
    public class ImpressoraMap : IEntityTypeConfiguration<Impressora>
    {
        public void Configure(EntityTypeBuilder<Impressora> builder)
        {
            builder.ToTable("base_Impressora");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Descricao).IsRequired().HasMaxLength(50);
        }
    }
}
