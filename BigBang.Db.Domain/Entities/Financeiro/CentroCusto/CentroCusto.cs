using Api.Domain.Entities;
using Domain.Entities.Cadastros.Empresa;

namespace Db.Domain.Entities.Cadastros
{
    public class CentroCusto : BaseEntity
    {
        public string Descricao { get; set; }
        public Empresas Empresa { get; set; }
        public int EmpresaId { get; set; }
    }
}
