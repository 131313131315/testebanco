using Domain.Entities.Cadastros.PapelUsuario;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Db.Data.Mapping
{
    public class FuncaoAcaoPerfilMap : IEntityTypeConfiguration<FuncaoAcaoPerfil>
    {
        public void Configure(EntityTypeBuilder<FuncaoAcaoPerfil> builder)
        {
            builder.ToTable("base_FuncaoAcaoPerfil");
            builder.HasKey(c => new { c.PerfilId, c.AcaoId, c.FuncaoId, c.Id });
            builder.Property(c => c.AcaoId).HasColumnName("IdAcao");
            builder.Property(c => c.FuncaoId).HasColumnName("IdFuncao");
            builder.Property(c => c.PerfilId).HasColumnName("IdPerfil");
            builder.Property(c => c.AcaoNome).HasMaxLength(35);
            builder.Property(c => c.FuncaoNome).HasMaxLength(60);
        }
    }
}
