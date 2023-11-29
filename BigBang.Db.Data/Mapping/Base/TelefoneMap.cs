using Domain.Entities.Cadastros.Empresa;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Db.Data.Mapping
{
    public class TelefoneMap : IEntityTypeConfiguration<Telefone>
    {
        public void Configure(EntityTypeBuilder<Telefone> builder)
        {
            builder.ToTable("base_Telefone");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.EmpresaId).HasColumnName("IdEmpresa");
            builder.Property(c => c.PessoaId).HasColumnName("IdPessoa");
        }
    }
}
