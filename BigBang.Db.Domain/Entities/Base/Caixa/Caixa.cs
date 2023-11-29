

using Db.Domain.Entities.Cadastros.Base;
using Db.Domain.Enum.Base;
using Domain.Entities;
using Domain.Entities.Cadastros.Empresa;
using System;

namespace Db.Domain.Entities.Base.Caixa
{
    public class Caixa : BaseEntityGenerico
    {
        public int UsuarioId { get; set; }
        public ApplicationUser Usuario { get; set; }
        public int EmpresaId { get; set; }
        public Empresas Empresa { get; set; }
        public SituacaoDoCaixa Situacao { get; set; }
        public decimal ValorDinheiro { get; set; }

        public decimal ValorDinheiroCalculado { get; set; }
        public decimal ValorTrocoCalculado { get; set; }
        public decimal ValorDinheiroRetirada { get; set; }
        public decimal ValorDeposito { get; set; }
        public decimal ValorDepositoCalculado { get; set; }
        public decimal ValorCredito { get; set; }
        public decimal ValorCreditoCalculado { get; set; }
        public decimal ValorCreditoRetirada { get; set; }
        public decimal ValorDebito { get; set; }
        public decimal ValorDebitoCalculado { get; set; }
        public decimal ValorDebitoRetirada { get; set; }
        public decimal ValorPixRetirada { get; set; }
        public decimal ValorPixDiferenca { get; set; }
        public decimal ValorPix { get; set; }
        public decimal ValorPixCalculado { get; set; }
        public decimal ValorFaturadoCalculado { get; set; }
        public decimal ValorDiferencaTotal { get; set; }
        public decimal ValorDinheiroDiferenca { get; set; }

        public decimal ValorCreditoDiferenca { get; set; }
        public decimal ValorDebitoDiferenca { get; set; }
        public decimal ValorDepositoDiferenca { get; set; }
        public decimal Acrescimo { get; set; }
        public decimal Desconto { get; set; }
        public string Observacao { get; set; }
        public string NomeMicro { get; set; }
        public int Sequencia { get; set; }
        public DateTime DataAbertura { get; set; }
        public DateTime? DataFechamento { get; set; }
        //public IEnumerable<MovimentacaoCaixa> MovimentacaoCaixa { get; set; }
    }
}
