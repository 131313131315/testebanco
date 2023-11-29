using Api.Domain.Entities;
using Db.Domain.Entities.Cadastros.DayUse.Cartao;
using Db.Domain.Entities.DayUse.AutoAtendimento;
using Db.Domain.Enum.DayUse;

namespace Db.Domain.Entities.Cadastros.DayUse
{
    public class Armario : BaseEntity
    {
        public int Numero { get; set; }
        public int BlocoId { get; set; }
        public AutomacaoLocalizacao Bloco { get; set; }
        public string? Observacao { get; set; }
        public bool Chave { get; set; }
        public int? CartaoConsumoId { get; set; }        
        public CartaoConsumo CartaoConsumo { get; set; }
        public SituacaoArmario SituacaoArmario { get; set; }
        public string? NumeroCartao { get; set; }
    }
}
