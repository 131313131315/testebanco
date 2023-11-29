using Db.Domain.Entities.Base.PessoaJuridicaFisica;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Db.Data.Mapping
{

    public class PessoaCreditoDebitoMap : IEntityTypeConfiguration<PessoaCreditoDebito>
    {
        public void Configure(EntityTypeBuilder<PessoaCreditoDebito> builder)
        {
            builder.ToTable("base_PessoaCreditoDebito");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.EmpresaId).HasColumnName("IdEmpresa");
            builder.Property(c => c.PessoaId).HasColumnName("IdItem");            
        }
    }
}

