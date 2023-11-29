using Db.Domain.Entities.Base.Caixa;
using Db.Domain.Entities.Cadastros.Base;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Db.Data.Mapping.DayUse
{
    public class MovimentacaoCaixaMap : IEntityTypeConfiguration<MovimentacaoCaixa>
    {
        public void Configure(EntityTypeBuilder<MovimentacaoCaixa> builder)
        {
            builder.ToTable("base_MovimentacaoCaixa");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.CaixaId).IsRequired().HasColumnName("IdCaixa");            
            builder.Property(c => c.EspacoLocacaoId).HasColumnName("IdEspacoLocacao");
        }
    }
}

