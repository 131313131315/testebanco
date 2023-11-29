using Domain.Entities;

namespace Db.Domain.Entities.Cadastros.Base.Metas
{
    public class MetaPorcentagem : BaseEntityGenerico
    {
        public string Descricao { get; set; }
        public decimal Porcentagem { get; set; }
        public int NumeroMeta { get; set; }
        public int EmpresaId { get; set; }
    }
}
