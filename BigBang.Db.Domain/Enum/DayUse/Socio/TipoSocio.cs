using System.ComponentModel.DataAnnotations;

namespace Db.Domain.Enum.DayUse.Socio
{
    public enum TipoSocio
    {
        [Display(Name = "Titular")]
        Titular = 1,
        [Display(Name = "Dependente")]
        Dependente = 2
    }
}
