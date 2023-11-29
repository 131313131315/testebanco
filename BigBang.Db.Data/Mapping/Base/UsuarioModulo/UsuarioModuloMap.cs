using Db.Domain.Entities.Base.UsuarioModulo;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Db.Data.Mapping
{
    public class UsuarioModuloMap : IEntityTypeConfiguration<UsuarioModulos>
    {
        public void Configure(EntityTypeBuilder<UsuarioModulos> builder)
        {
            builder.ToTable("base_UsuarioModulos");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.ModuloId).HasColumnName("IdModulo");
            builder.Property(c => c.UsuarioId).HasColumnName("IdUsuario");
        }
    }
}

