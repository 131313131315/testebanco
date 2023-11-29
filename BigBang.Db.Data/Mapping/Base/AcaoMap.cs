using Domain.Entities.Cadastros.PapelUsuario;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Db.Data.Mapping
{
    public class AcaoMap : IEntityTypeConfiguration<Acao>
    {
        public void Configure(EntityTypeBuilder<Acao> builder)
        {
            builder.ToTable("base_Acao");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Nome).IsRequired().HasMaxLength(35);
            builder.Property(c => c.Descricao).IsRequired().HasMaxLength(60);
        }
    }
}
