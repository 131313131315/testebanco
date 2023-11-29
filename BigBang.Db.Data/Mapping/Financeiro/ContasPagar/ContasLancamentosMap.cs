using Db.Domain.Entities.Cadastros;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Db.Data.Mapping
{
    public class ContasLancamentosMap : IEntityTypeConfiguration<ContasLancamentos>
    {
        public void Configure(EntityTypeBuilder<ContasLancamentos> builder)
        {
            builder.ToTable("fin_ContasLancamentos");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Descricao).HasMaxLength(100);
            builder.Property(c => c.CategoriaContasId).HasColumnName("IdCategoriaContas");
            builder.Property(c => c.CentroCustoId).HasColumnName("IdCentroCusto");
            builder.Property(c => c.ContaBancariaId).HasColumnName("IdContaBancaria");
            builder.Property(c => c.ClienteFornecedorId).HasColumnName("IdClienteFornecedor");
            builder.Property(c => c.EmpresaId).HasColumnName("IdEmpresa");
        }
    }
}
