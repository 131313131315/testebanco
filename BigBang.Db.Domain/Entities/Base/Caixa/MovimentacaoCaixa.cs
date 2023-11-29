

using Db.Domain.Entities.Cadastros.DayUse;
using Db.Domain.Entities.DayUse;
using Db.Domain.Enum;
using Db.Domain.Enum.Base;
using Domain.Entities;
using System;

namespace Db.Domain.Entities.Base.Caixa
{
    public class MovimentacaoCaixa : BaseEntityGenerico
    {
        //falta as informacoes sobre a reserva do hotel
        public int CaixaId { get; set; }

        public Caixa Caixa { get; set; }
        public int? EspacoLocacaoId { get; set; }
        public int? NumeroComprovante { get; set; }
        public EspacoLocacao EspacoLocacao { get; set; }
        public int? ExcursaoId { get; set; }
        public int? IdMovimentoCartao { get; set; }
        public Excursao Excursao { get; set; }
        public DateTime DataMovimento { get; set; }
        public decimal ValorMovimento { get; set; }
        public TipoCategoriaContas Natureza { get; set; }
        public TipoMovimento TipoMovimento { get; set; }
        public TipoEspecie TipoMoeda { get; set; }
        public string Observacao { get; set; }
        public bool Estorno { get; set; }
        public decimal Acrescimo { get; set; }
        public decimal Desconto { get; set; }
        public bool Adiantamento { get; set; }
        public DateTime? DataEstorno { get; set; }
        public TipoPagamento TipoPagamento { get; set; }
    }
}
