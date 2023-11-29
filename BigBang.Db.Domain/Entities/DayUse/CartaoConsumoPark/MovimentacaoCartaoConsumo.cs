using Db.Domain.Entities.Base.Caixa;
using Db.Domain.Entities.Cadastros.Base;
using Db.Domain.Entities.DayUse.AutoAtendimento;
using Db.Domain.Entities.DayUse.TEF;
using Db.Domain.Enum.DayUse;
using Domain.Entities;
using Domain.Entities.Cadastros.Empresa;
using System;

namespace Db.Domain.Entities.Cadastros.DayUse.Cartao
{
    public class MovimentacaoCartaoConsumo : BaseEntityGenerico
    {
        public int? CartaoConsumoId { get; set; }
        public CartaoConsumo CartaoConsumo { get; set; }
        public int? NumeroComprovante { get; set; }
        public int? NumeroPagamento { get; set; }
        public int? CaixaId { get; set; }
        public Caixa Caixa { get; set; }
        public int? EmpresaId { get; set; }
        public Empresas Empresa { get; set; }
        public int? MovimentacaoCaixaId { get; set; }
        public MovimentacaoCaixa MovimentacaoCaixa { get; set; }
        public DateTime Data { get; set; }
        public decimal Valor { get; set; }
        public TipoMovimentoCartao TipoMovimentoCartao { get; set; }
        //public TerminaisTef Terminal { get; set; }
        //public int? TerminalId { get; set; }
        public AutomacaoLocalizacao Terminal { get; set; }
        public int? TerminalId { get; set; }

 
    }
}
