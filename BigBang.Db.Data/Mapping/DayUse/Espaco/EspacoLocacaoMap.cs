using Db.Domain.Entities.Cadastros.DayUse;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Db.Data.Mapping
{
    public class EspacoLocacaoMap : IEntityTypeConfiguration<EspacoLocacao>
    {
        public void Configure(EntityTypeBuilder<EspacoLocacao> builder)
        {
            builder.ToTable("park_EspacoLocacao");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.PessoaId).HasColumnName("IdPessoa");
            builder.Property(c => c.EspacoId).HasColumnName("IdEspaco");
            builder.Property(c => c.UsuarioId).HasColumnName("IdUsuario");
            builder.Property(c => c.ExcursaoId).HasColumnName("IdExcursao");
            builder.Property(c => c.UsuarioRecebimentoId).HasColumnName("IdUsuarioRecebimento");
        }
    }
}
