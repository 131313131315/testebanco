using Domain.Entities;

namespace Db.Domain.Entities.Cadastros.DayUse
{
    public class Catraca : BaseEntityGenerico
    {
        public string Descricao { get; set; }
        public string Ip { get; set; }
        public bool ComandoAbrirFechar { get; set; }
    }
}
