using Db.Domain.Entities.Base.NotaFiscal;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Db.Data.Mapping
{
    public class NotaFiscalNfceMap : IEntityTypeConfiguration<NotaFiscalNfce>
    {
        public void Configure(EntityTypeBuilder<NotaFiscalNfce> builder)
        {
            builder.ToTable("base_NotaFiscalNfce");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.ChaveAcesso).HasMaxLength(70);
            builder.Property(c => c.CpfCnpj).HasMaxLength(30);
            builder.Property(c => c.Protocolo).HasMaxLength(30);
            builder.Property(c => c.ProtocoloCancelado).HasMaxLength(30);
            builder.Property(c => c.ProtocoloInutilizado).HasMaxLength(30);
        }
    }
}

