using Db.Domain.Entities.Cadastros.DayUse;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Db.Data.Mapping
{
    public class EspacoPreReservaMap : IEntityTypeConfiguration<EspacoPreReserva>
    {
        public void Configure(EntityTypeBuilder<EspacoPreReserva> builder)
        {
            builder.ToTable("park_EspacoPreReserva");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.EspacoId).HasColumnName("IdEspaco");
            builder.Property(c => c.UsuarioId).HasColumnName("IdUsuario");
        }
    }
}
