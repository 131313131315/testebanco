using System.ComponentModel.DataAnnotations;

namespace Db.Domain.Enum.Base
{
    public enum TipoPagamento
    {
        [Display(Name = "Dinheiro")]
        Dinheiro = 1,
        [Display(Name = "Credito")]
        Credito = 2,
        [Display(Name = "Debito")]
        Debito = 3,
        [Display(Name = "Deposito")]
        Deposito = 4,
        [Display(Name = "Faturado")]
        Faturado = 5,
        [Display(Name = "Pix")]
        Pix = 6
    }
}
