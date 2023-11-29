using Domain.Entities.Cadastros.PessoaJuridicaFisica;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Db.Data.Mapping
{
    public class PessoaMap : IEntityTypeConfiguration<Pessoa>
    {
        public void Configure(EntityTypeBuilder<Pessoa> builder)
        {
            builder.ToTable("base_Pessoa");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Nome).HasMaxLength(150);
            builder.Property(c => c.NomeFantasia).HasMaxLength(100);
            builder.Property(c => c.Razao).HasMaxLength(100);
            builder.Property(c => c.Responsavel).HasMaxLength(100);
            builder.Property(c => c.RgInscEstadual).HasMaxLength(15);
            builder.Property(c => c.TipoPessoa).HasMaxLength(3);
            builder.Property(c => c.OrgaoExpedidor).HasMaxLength(10);
            builder.Property(c => c.CpfCnpj).HasMaxLength(20);
            builder.Property(c => c.Email).HasMaxLength(50);
            builder.Property(c => c.Estado).HasMaxLength(30);
            builder.Property(c => c.InscricaoMunicipal).HasMaxLength(40);
            builder.Property(c => c.Passaporte).HasMaxLength(50);
            builder.Property(c => c.Nacionalidade).HasMaxLength(30);
            builder.Property(c => c.RegNacExtrangeiro).HasMaxLength(20);
            builder.Property(c => c.Sexo).HasMaxLength(10);
            builder.Property(c => c.NomeMae).HasMaxLength(100);
            builder.Property(c => c.Profissao).HasMaxLength(50);
            builder.Property(c => c.Certidao).HasMaxLength(50);
            builder.Property(c => c.CategoriaSocioId).HasColumnName("IdCategoriaSocio");
            builder.Property(c => c.TituloSocioId).HasColumnName("IdTituloSocio");
            builder.Property(c => c.UsuarioId).HasColumnName("IdUsuario");
        }
    }
}
