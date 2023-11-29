using Domain.Entities;

namespace Db.Domain.Entities.Cadastros.Base.Configuracao
{
    public class ConfiguracaoDayUse : BaseEntityGenerico
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public bool Situacao { get; set; }
        public string Valor { get; set; }
    }
}
