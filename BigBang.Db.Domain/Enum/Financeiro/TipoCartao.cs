using System.ComponentModel.DataAnnotations;

namespace Db.Domain.Enum
{
    public enum TipoCartao
    {
        [Display(Name = "Visa")]
        Visa = 1,
        [Display(Name = "Mastercard")]
        Master = 2,
        [Display(Name = "Diners")]
        Diners = 3,
        [Display(Name = "American Express")]
        AmericanExpress = 4,
        [Display(Name = "Elo")]
        Elo = 5,
        [Display(Name = "Hipercard")]
        Hipercard = 6,
        [Display(Name = "Outro")]
        Outro = 7,
    }
}
