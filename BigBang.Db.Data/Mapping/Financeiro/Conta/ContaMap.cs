using Db.Domain.Entities.Cadastros;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Db.Data.Mapping
{
    public class ContaMap : IEntityTypeConfiguration<ContaBancaria>
    {
        public void Configure(EntityTypeBuilder<ContaBancaria> builder)
        {
            builder.ToTable("fin_ContasBancaria");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Descricao).IsRequired().HasMaxLength(60);
            builder.Property(c => c.Padrao).IsRequired();
            builder.Property(c => c.TipoConta).IsRequired();
            builder.Property(c => c.Saldo).IsRequired();
            builder.Property(c => c.EmpresaId).HasColumnName("IdEmpresa");
        }
    }
}