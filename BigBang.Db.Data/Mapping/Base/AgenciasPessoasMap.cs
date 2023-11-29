using Db.Domain.Entities.Base.PessoaJuridicaFisica;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Db.Data.Mapping
{
    public class AgenciasPessoasMap : IEntityTypeConfiguration<AgenciasPessoas>
    {
        public void Configure(EntityTypeBuilder<AgenciasPessoas> builder)
        {
            builder.ToTable("base_AgenciasPessoas");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.PessoaId).IsRequired().HasColumnName("IdPessoa");
            builder.Property(c => c.AgenciaId).IsRequired().HasColumnName("IdAgencia");
            builder.HasOne(x => x.Pessoa).WithMany(x => x.Agencias);
        }
    }
}

