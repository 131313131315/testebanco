using System.ComponentModel.DataAnnotations;

namespace Db.Domain.Enum.DayUse
{
    public enum TipoVendaPark
    {
        [Display(Name = "Park")]
        Park = 1,
        [Display(Name = "Externo")]
        Externo = 2,
        [Display(Name = "Site")]
        Site = 3
    }
}