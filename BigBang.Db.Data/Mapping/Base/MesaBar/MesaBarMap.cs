
using Db.Domain.Entities.Base.Mesa;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Db.Data.Mapping
{ 
    public class MesaBarMap : IEntityTypeConfiguration<MesaBar>
    {
        public void Configure(EntityTypeBuilder<MesaBar> builder)
        {
            builder.ToTable("base_MesaBar");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.EmpresaId).HasColumnName("IdEmpresa");

        }
    }

}
