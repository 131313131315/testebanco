using System.ComponentModel.DataAnnotations;

namespace Db.Domain.Enum.DayUse
{
    public enum SituacaoCartao
    {
        [Display(Name = "Livre")]
        Livre = 1,
        [Display(Name = "Perdido")]
        Perdido = 2,
        [Display(Name = "Ocupado")]
        Ocupado = 3,
        [Display(Name = "Retido")]
        Retido = 4,
        [Display(Name = "Devolvido")]
        Devolvido = 5,
        [Display(Name = "Mestre")]
        Mestre = 6,
    }
}
