using Api.Domain.Entities;
using Db.Domain.Enum;

namespace Db.Domain.Entities.Financeiro.CategoriaContas
{
    public class DemonstrativoResultadoExercicio : BaseEntity
    {
        public string Descricao { get; set; }
        public TipoCategoriaContas TipoCategoria { get; set; }
    }
}
