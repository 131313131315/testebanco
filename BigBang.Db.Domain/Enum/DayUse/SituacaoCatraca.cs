using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Db.Domain.Enum.DayUse
{
    public enum SituacaoCatraca
    {
        [Display(Name = "Nao-libera")]
        NaoLiberado = 1,
        [Display(Name = "Liberado")]
        Liberado = 2,
        [Display(Name = "liberado-BoaViajem")]
        LiberadoBoaViajem = 3,
    }
}
