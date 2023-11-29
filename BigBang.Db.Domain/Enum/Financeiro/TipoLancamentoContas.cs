using System.ComponentModel.DataAnnotations;

namespace Db.Domain.Enum
{
    public enum TipoLancamentoContas
    {
        [Display(Name = "Contas Receber")]
        ContasReceber = 1,
        [Display(Name = "Contas Pagar")]
        ContasPagar = 2,
        [Display(Name = "Transferência Entrada")]
        TranferenciaEntrada = 3,
        [Display(Name = "Transferência Saida")]
        TranferenciaSaida = 4,
        [Display(Name = "Saldo Inicial")]
        SaldoInicial = 5,
    }
}
