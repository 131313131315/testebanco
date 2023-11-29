
using Domain.Entities;

namespace Db.Domain.Entities.Cadastros.Base.Metas
{
    public class MetaMensal : BaseEntityGenerico
    {
        public string Ano { get; set; }
        public string Mes { get; set; }
        public int MetaId { get; set; }
        public MetaPorcentagem Meta { get; set; }
        public decimal ValorAtingido { get; set; }
        public decimal ValorPago { get; set; }
        public decimal QuantidadePontos { get; set; }
        public int PontosMetaId { get; set; }
        public PontosMeta PontosMeta { get; set; }
    }
}
