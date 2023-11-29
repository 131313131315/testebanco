using Domain.Entities.Cadastros.Empresa;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Db.Data.Mapping
{
    public class EmpresaMap : IEntityTypeConfiguration<Empresas>
    {
        public void Configure(EntityTypeBuilder<Empresas> builder)
        {
            builder.ToTable("base_Empresa");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.RazaoSocial).HasMaxLength(100);
            builder.Property(c => c.Fantasia).HasMaxLength(100);
            builder.Property(c => c.Cnpj).HasMaxLength(30);
            builder.Property(c => c.InscricaoEstadual).HasMaxLength(60);
            builder.Property(c => c.InscricaoMunicipal).HasMaxLength(30);
            builder.Property(c => c.TipoEmpresa).HasMaxLength(10);
            builder.Property(c => c.Logo).HasColumnType("image");
            builder.Property(c => c.Ativo).HasDefaultValue(true);
            builder.Property(c => c.NFCe).HasDefaultValue(false);
            builder.Property(c => c.NFSe).HasDefaultValue(false);
            builder.Property(c => c.NFe).HasDefaultValue(false);
            builder.Property(c => c.MostrarValorVendas).HasDefaultValue(false);
            builder.Property(c => c.Bloqueio).HasDefaultValue(false);
            builder.Property(c => c.Porcentagem).HasDefaultValue(0);
            builder.Property(c => c.InscricaoMunicipal).IsRequired(false);
        }
    }
}
