using Domain.Entities.Cadastros.EmpresaNFs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Db.Data.Mapping
{
    public class EmpresaNfMap : IEntityTypeConfiguration<EmpresaNF>
    {
        public void Configure(EntityTypeBuilder<EmpresaNF> builder)
        {
            builder.ToTable("base_EmpresaNF");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Certificado).HasMaxLength(200);
            builder.Property(c => c.IdTokenHomologacao).HasMaxLength(6);
            builder.Property(c => c.IdTokenProducao).HasMaxLength(6);
            builder.Property(c => c.CscHomologacao).HasMaxLength(40);
            builder.Property(c => c.CscProducao).HasMaxLength(40);
            builder.Property(c => c.Crt).HasMaxLength(3);
            builder.Property(c => c.SerieNota).HasMaxLength(3);
            builder.Property(c => c.EmpresaId).HasColumnName("IdEmpresa");
            builder.Property(c => c.EmpresaNotaId).HasColumnName("IdEmpresaNota");
        }
    }

}
