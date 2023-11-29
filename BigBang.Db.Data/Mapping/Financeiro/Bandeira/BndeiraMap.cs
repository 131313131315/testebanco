using Db.Domain.Entities.Financeiro.Bandeira;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Db.Data.Mapping
{
    public class BandeiraMap : IEntityTypeConfiguration<Bandeira>
    {
        public void Configure(EntityTypeBuilder<Bandeira> builder)
        {
            builder.ToTable("fin_Bandeira");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Descricao).IsRequired().HasMaxLength(100);
        }
    }
}
