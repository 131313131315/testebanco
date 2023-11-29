using Domain.Entities.Cadastros.Produto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Db.Data.Mapping
{
    public class PontoVendaMap : IEntityTypeConfiguration<PontoVenda>
    {
        public void Configure(EntityTypeBuilder<PontoVenda> builder)
        {
            builder.ToTable("base_PontoVenda");
            builder.HasKey(c => c.Id);
        }
    }
}
