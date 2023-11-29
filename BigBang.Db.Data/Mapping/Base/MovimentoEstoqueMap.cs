using Domain.Entities.Cadastros.Produto;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Db.Data.Mapping.Base
{


    public class MovimentoEstoqueMap : IEntityTypeConfiguration<MovimentoEstoque>
    {
        public void Configure(EntityTypeBuilder<MovimentoEstoque> builder)
        {
            builder.ToTable("base_MovimentoEstoque");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.ItemId).HasColumnName("IdItem");
            builder.Property(c => c.EmpresaId).HasColumnName("IdEmpresa");
        }
    }
}
