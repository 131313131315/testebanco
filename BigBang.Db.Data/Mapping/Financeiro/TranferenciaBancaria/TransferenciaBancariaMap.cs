using Db.Domain.Entities.Financeiro.Conta;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Db.Data.Mapping
{
    public class TransferenciaBancariaMap : IEntityTypeConfiguration<TransferenciaBancaria>
    {
        public void Configure(EntityTypeBuilder<TransferenciaBancaria> builder)
        {
            builder.ToTable("fin_TransferenciaBancaria");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Descricao).IsRequired().HasMaxLength(50);
        }
    }
}
