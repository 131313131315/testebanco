
using Api.Domain.Entities;
using Db.Domain.Entities.Cadastros.Base;
using Domain.Entities.Cadastros.Empresa;

namespace Db.Domain.Entities.Base.UsuarioEmpresa
{
    public class UsuarioEmpresa : BaseEntity
    {
        public int UsuarioId { get; set; }
        public ApplicationUser Usuario { get; set; }
        public Empresas Empresa { get; set; }
        public int EmpresaId { get; set; }
    }
}
