using System.ComponentModel.DataAnnotations;

namespace Db.Domain.Enum
{
    public enum TipoConta
    {
        [Display(Name = "Corrente")]
        Corrente = 1,
        [Display(Name = "Poupança")]
        Poupanca = 2,
        [Display(Name = "Caixinha")]
        Caixinha = 3,
        [Display(Name = "Cartao de Credito")]
        CartaoCredito = 4,
        [Display(Name = "Investimento")]
        Investimento = 5,
        [Display(Name = "Aplicação automatica")]
        AplicacaoAutomatica = 6,
    }
}
