using Db.Domain.Entities.Cadastros.DayUse;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Db.Data.Mapping
{
    public class EspacoEsperaMap : IEntityTypeConfiguration<EspacoEspera>
    {
        public void Configure(EntityTypeBuilder<EspacoEspera> builder)
        {
            builder.ToTable("park_EspacoEspera");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.PessoaId).HasColumnName("IdPessoa");
        }
    }
}
