using Domain.Entities.Cadastros.PapelUsuario;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Db.Data.Mapping
{
    public class FuncaoAcoesMap : IEntityTypeConfiguration<FuncaoAcoes>
    {
        public void Configure(EntityTypeBuilder<FuncaoAcoes> builder)
        {
            builder.ToTable("base_FuncaoAcoes");
            builder.HasKey(c => new { c.FuncaoId, c.AcaoId });
            builder.Property(c => c.AcaoId).HasColumnName("IdAcao");
            builder.Property(c => c.FuncaoId).HasColumnName("IdFuncao");
            builder.Property(c => c.AcaoNome).HasMaxLength(35);
            builder.Property(c => c.FuncaoNome).HasMaxLength(60);
        }
    }
}
