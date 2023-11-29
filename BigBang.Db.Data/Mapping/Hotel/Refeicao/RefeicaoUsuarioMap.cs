using Db.Domain.Entities.Hotel.Quartos;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Db.Domain.Entities.Hotel.Refeicao;

namespace Db.Data.Mapping.Hotel.Refeicao
{

    public class RefeicaoUsuarioMap : IEntityTypeConfiguration<RefeicaoUsuario>
    {
        public void Configure(EntityTypeBuilder<RefeicaoUsuario> builder)
        {
            builder.ToTable("hotel_RefeicaoUsuario");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.UsuarioId).HasColumnName("IdUsuario");
            builder.Property(c => c.CartaoId).HasColumnName("IdCartao");
            builder.Property(c => c.RefeicaoId).HasColumnName("IdRefeicao");

        }
    }
}
