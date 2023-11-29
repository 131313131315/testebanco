using Db.Domain.Entities.DayUse;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Db.Data.Mapping.DayUse
{
    public class ExcursaoMap : IEntityTypeConfiguration<Excursao>
    {
        public void Configure(EntityTypeBuilder<Excursao> builder)
        {
            builder.ToTable("park_Excursao");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.PessoaId).IsRequired().HasColumnName("IdPessoa");
            builder.Property(c => c.UsuarioRecebimentoId).HasColumnName("IdUsuarioRecebimento");
            builder.Property(c => c.UsuarioVendaId).IsRequired().HasColumnName("IdUsuarioVenda");
            builder.Property(c => c.AgenciaId).HasColumnName("IdAgencia");
        }
    }
}

