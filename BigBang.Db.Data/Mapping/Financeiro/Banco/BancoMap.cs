using Db.Domain.Entities.Cadastros;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Db.Data.Mapping
{
    public class BancosMap : IEntityTypeConfiguration<Bancos>
    {
        public void Configure(EntityTypeBuilder<Bancos> builder)
        {
            builder.ToTable("fin_Banco");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Descricao).IsRequired().HasMaxLength(100);
        }
    }
}
