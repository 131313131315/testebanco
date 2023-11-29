using Api.Domain.Entities;
using Db.Domain.Entities.Financeiro.CategoriaContas;
using Db.Domain.Enum;

namespace Db.Domain.Entities.Cadastros
{
    public class CategoriaContas : BaseEntity
    {
        public string Descricao { get; set; }
        public int IdEmpresa { get; set; }
        public TipoCategoriaContas Natureza { get; set; }
        public DemonstrativoResultadoExercicio Dre { get; set; }
        public int? DreId { get; set; }
        public int CentroCustoId { get; set; }
        public bool Pai { get; set; }
        public bool Usando { get; set; }
    }
}
