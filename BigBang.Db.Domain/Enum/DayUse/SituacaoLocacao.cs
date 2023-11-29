using System.ComponentModel.DataAnnotations;

namespace Db.Domain.Enum.DayUse
{
    public enum SituacaoLocacao
    {
        [Display(Name = "Reservado")]
        Reservado = 1,
        [Display(Name = "Alugado")]
        Alugado = 2,
        [Display(Name = "Compareceu")]
        Compareceu = 3,
        [Display(Name = "Cancelado")]
        Cancelado = 4,
        [Display(Name = "Livre")]
        Livre = 5,
        [Display(Name = "Pre-reservado")]
        PreReservado = 6
    }
}
