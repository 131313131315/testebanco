using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Db.Domain.Enum.DayUse
{
    public enum TipoCartaoConsumo
    {
        [Display(Name = "Parque")]
        Parque = 1,
        [Display(Name = "Hotel")]
        Hotel = 2,
        [Display(Name = "NFCe")]
        NFCe = 3,
        [Display(Name = "POSCARGA")]
        POSCARGA = 4,
        [Display(Name = "IMPRESSAO")]
        IMPRESSAO = 5
    }
}
