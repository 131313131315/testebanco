using Db.Domain.Entities.Base.UsuarioEmpresa;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Db.Data.Mapping
{
    public class UsuarioEmpresaMap : IEntityTypeConfiguration<UsuarioEmpresa>
    {
        public void Configure(EntityTypeBuilder<UsuarioEmpresa> builder)
        {
            builder.ToTable("base_UsuarioEmpresa");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.EmpresaId).HasColumnName("IdEmpresa");
            builder.Property(c => c.UsuarioId).HasColumnName("IdUsuario");
        }
    }
}

