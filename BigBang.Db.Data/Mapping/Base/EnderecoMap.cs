using Domain.Entities.Cadastros.Empresa;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Db.Data.Mapping
{
    public class EnderecoMap : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.ToTable("base_Endereco");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.EmpresaId).HasColumnName("IdEmpresa");
            builder.Property(c => c.PessoaId).HasColumnName("IdPessoa");
            builder.Property(c => c.Cidade).HasMaxLength(80);
            builder.Property(c => c.Complemento).HasMaxLength(30);
            builder.Property(c => c.Estado).HasMaxLength(60);
            builder.Property(c => c.Pais).HasMaxLength(30);
            builder.Property(c => c.Rua).HasMaxLength(80);
        }
    }
}
