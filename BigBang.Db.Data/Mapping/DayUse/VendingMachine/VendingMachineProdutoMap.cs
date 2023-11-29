using Db.Domain.Entities.DayUse.VendingMachine;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Db.Data.Mapping.DayUse
{
    public class VendingMachineProdutoMap : IEntityTypeConfiguration<VendingMachineProduto>
    {
        public void Configure(EntityTypeBuilder<VendingMachineProduto> builder)
        {
            builder.ToTable("park_VendingMachineProduto");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.VendingMachineId).HasColumnName("IdVendingMachine");
            builder.Property(c => c.ItemId).HasColumnName("IdItem");
        }
    }
}
