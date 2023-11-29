using Api.Domain.Entities;

namespace Db.Domain.Entities.Cadastros.DayUse
{
    public class TamanhoEspaco : BaseEntity
    {
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public decimal PrecoTitular { get; set; }
        public decimal PrecoFeriado { get; set; }
        public decimal PrecoFeriadoTitular { get; set; }
    }
}
