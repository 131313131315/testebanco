using Api.Domain.Entities;
using Db.Domain.Enum.DayUse.Socio;

namespace Db.Domain.Entities.Cadastros.Socio.CategoriaSocio
{
    public class CategoriaSocio : BaseEntity
    {
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public decimal Juros { get; set; }
        public decimal Descontos { get; set; }
        public TipoCobranca TipoCobranca { get; set; }
    }
}
