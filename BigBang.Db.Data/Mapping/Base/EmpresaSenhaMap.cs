using Db.Domain.Entities.Base.EmpresaSenha;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Db.Data.Mapping.Base
{
    public class EmpresaSenhaMap : IEntityTypeConfiguration<EmpresaSenha>
    {
        public void Configure(EntityTypeBuilder<EmpresaSenha> builder)
        {
            builder.ToTable("base_EmpresaSenha");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.EmpresaId).HasColumnName("IdEmpresa");
        }
    }

}
