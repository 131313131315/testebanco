using Db.Domain.Entities.Cadastros;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Db.Data.Mapping.DayUse.Socio
{
    public class CobradoresMap : IEntityTypeConfiguration<Cobradores>
    {
        public void Configure(EntityTypeBuilder<Cobradores> builder)
        {
            builder.ToTable("socio_Cobradores");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Descricao).HasMaxLength(50);
            builder.Property(c => c.CodigoBeneficiario).HasMaxLength(50);
            builder.Property(c => c.NossoNumeroUltimo).HasMaxLength(50);
            builder.Property(c => c.LocalPagamento).HasMaxLength(30);
            builder.Property(c => c.InstrucaoCobranca).HasMaxLength(100);
            builder.Property(c => c.TipoEspecie).IsRequired();
            builder.Property(c => c.TituloDocEspecie).IsRequired();
            builder.Property(c => c.FormatoArquivoRemessa).IsRequired();
            builder.Property(c => c.TipoJuros).IsRequired();
            builder.Property(c => c.PercentualJuros).IsRequired();
            builder.Property(c => c.TipoMulta).IsRequired();
            builder.Property(c => c.PercentualMulta).IsRequired();
            builder.Property(c => c.TipoDesconto).IsRequired();
            builder.Property(c => c.QuantidadeDiasDescontos).IsRequired();
            builder.Property(c => c.EmpresaId).HasColumnName("IdEmpresa");
            builder.Property(c => c.ContaId).HasColumnName("IdConta");
        }
    }
}