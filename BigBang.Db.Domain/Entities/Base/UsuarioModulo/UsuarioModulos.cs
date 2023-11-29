using Api.Domain.Entities;
using Db.Domain.Entities.Cadastros.Base;
using Domain.Entities.Cadastros.Modulos;

namespace Db.Domain.Entities.Base.UsuarioModulo
{
    public class UsuarioModulos : BaseEntity
    {
        public ApplicationUser Usuario { get; set; }
        public int UsuarioId { get; set; }
        public Modulos Modulo { get; set; }
        public int ModuloId { get; set; }
    }
}
