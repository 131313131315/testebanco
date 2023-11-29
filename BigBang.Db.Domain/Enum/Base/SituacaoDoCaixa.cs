using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Db.Domain.Enum.Base
{
    public enum SituacaoDoCaixa
    {
        [Display(Name = "Aberto")]
        Aberto = 1,
        [Display(Name = "Fechado")]
        Fechado = 0,
        [Display(Name = "FechadoDataCorrente")]
        FechadoDataCorrente = 2,
        [Display(Name = "AbertoDiaAnterior")]
        AbertoDiaAnterior = 3
    }
}
