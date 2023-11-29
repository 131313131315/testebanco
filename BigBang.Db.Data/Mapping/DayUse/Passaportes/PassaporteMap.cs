using Db.Domain.Entities.Cadastros.DayUse.Passaportes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Db.Data.Mapping.DayUse
{
    public class PassaporteMap : IEntityTypeConfiguration<Passaporte>
    {
        public void Configure(EntityTypeBuilder<Passaporte> builder)
        {
            builder.ToTable("park_Passaporte");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.NumeroPassaporte).HasMaxLength(20);
            builder.Property(c => c.NumeroTituloCota).HasMaxLength(20);
            builder.Property(c => c.Voucher).HasMaxLength(50);
            builder.Property(c => c.PessoaId).HasColumnName("IdPessoa");
            builder.Property(c => c.UsuarioId).IsRequired().HasColumnName("IdUsuario");
            builder.Property(c => c.PassaportePromocaoId).HasColumnName("IdPassaportePromocao");
            builder.Property(c => c.CaixaId).HasColumnName("IdCaixa");
        }
    }
}
