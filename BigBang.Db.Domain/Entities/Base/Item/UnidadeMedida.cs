using Api.Domain.Entities;

namespace Db.Domain.Entities.Base.Item
{
    public class UnidadeMedida : BaseEntity
    {
        public string Descricao { get; set; }
        public string DescricaoReduzida { get; set; }
        public string BaseConversao { get; set; }
    }
}
