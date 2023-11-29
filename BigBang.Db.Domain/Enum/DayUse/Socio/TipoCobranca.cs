using System.ComponentModel.DataAnnotations;

namespace Db.Domain.Enum.DayUse.Socio
{
    public enum TipoCobranca
    {
        [Display(Name = "Mensal")]
        Mensal = 1,
        [Display(Name = "Bimestre")]
        Bimestre = 2,
        [Display(Name = "Trimestre")]
        Trimestre = 3,
        [Display(Name = "Semestre")]
        Semestre = 4,
        [Display(Name = "Anual")]
        Anual = 5
    }
}
