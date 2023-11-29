using Db.Domain.Enum.TEF;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Db.Domain.Entities.DayUse.TEF
{
    public class TransacoesTEF : BaseEntityGenerico
    {
        public int IntencaoVendaId { get; set; }
        public string Referencia { get; set; }
        public string Token { get; set; }
        public string DataTransacao { get; set; }
        public decimal ValorOriginal { get; set; }
        public decimal ValorAcrescimo { get; set; }
        public decimal ValorDesconto { get; set; }
        public decimal ValorFinal { get; set; }
        public int QuantidadeParcelas { get; set; }
        public FormaPagamentoPayGo FormaPagamento { get; set; }
        public int TerminalId { get; set; }
        public StatusIntencaoVendaPayGo Status { get; set; }
        public int ProdutoPayGoId { get; set; }
        public string Gate2allToken { get; set; }
        public string UrlPagamento { get; set; }
        public string NumeroComprovante { get; set; }
        public string FinalCartao { get; set; }
    }
}
