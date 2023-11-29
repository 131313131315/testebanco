using System.ComponentModel.DataAnnotations;

namespace Db.Domain.Enum.Base
{
    public enum TipoLancamentoPessoa
    {
        [Display(Name = "Crédito")]
        Credito = 1,
        [Display(Name = "Débito")]
        Debito = 2,       
    }
    public enum DestinoCreditoDebito
    {
        [Display(Name = "TrocaEspaco")]
        TrocaEspaco = 1,
        [Display(Name = "ResgateCredito")]
        ResgateCredito = 2,
        [Display(Name = "PagarDebito")]
        PagarDebito = 3,
    }
}
