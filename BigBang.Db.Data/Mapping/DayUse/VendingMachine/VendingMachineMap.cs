using Db.Domain.Entities.DayUse.VendingMachine;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Db.Data.Mapping.DayUse
{
    public class VendingMachineMap : IEntityTypeConfiguration<VendingMachine>
    {
        public void Configure(EntityTypeBuilder<VendingMachine> builder)
        {
            builder.ToTable("park_VendingMachine");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.EmpresaId).HasColumnName("IdEmpresa");
        }
    }
}