using Db.Domain.Entities.Base.PessoaJuridicaFisica;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Db.Data.Mapping.Base
{
    public class AgendaTelefonicaMap : IEntityTypeConfiguration<AgendaTelefonica>
    {
        public void Configure(EntityTypeBuilder<AgendaTelefonica> builder)
        {
            builder.ToTable("base_AgendaTelefonica");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Nome).IsRequired().HasMaxLength(100);
            builder.Property(c => c.Telefone01).IsRequired().HasMaxLength(20);
            builder.Property(c => c.Telefone02).IsRequired().HasMaxLength(20);
            builder.Property(c => c.Celular).IsRequired().HasMaxLength(20);
        }
    }
}
