using Db.Domain.Entities.Base.Caixa;
using Db.Domain.Entities.Cadastros.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Db.Data.Mapping.DayUse
{
    public class CaixaMap : IEntityTypeConfiguration<Caixa>
    {
        public void Configure(EntityTypeBuilder<Caixa> builder)
        {
            builder.ToTable("base_Caixa");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.NomeMicro).HasMaxLength(30);
            builder.Property(c => c.UsuarioId).IsRequired().HasColumnName("IdUsuario");
            builder.Property(c => c.EmpresaId).IsRequired().HasColumnName("IdEmpresa");
        }
    }
}

