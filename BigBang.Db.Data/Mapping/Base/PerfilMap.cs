using Domain.Entities.Cadastros.PapelUsuario;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Db.Data.Mapping
{
    public class PerfilMap : IEntityTypeConfiguration<Perfil>
    {
        public void Configure(EntityTypeBuilder<Perfil> builder)
        {
            builder.ToTable("base_Perfil");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Nome).HasMaxLength(50);
            builder.Property(c => c.Descricao).HasMaxLength(50);
            builder.Property(c => c.TempoExpiracao).HasMaxLength(15);
        }
    }
}
