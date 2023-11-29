using Api.Domain.Entities;
using Domain.Entities.Cadastros.Empresa;

namespace Db.Domain.Entities.DayUse.VendingMachine
{
    public class VendingMachine : BaseEntity
    {
        public string Descricao { get; set; }
        public string IP { get; set; }
        public int? EmpresaId { get; set; }
        public Empresas Empresa { get; set; }
    }
}
