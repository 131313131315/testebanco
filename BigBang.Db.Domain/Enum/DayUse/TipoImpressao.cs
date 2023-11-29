

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Db.Domain.Enum.DayUse
{
    public enum TipoImpressao
    {
        [Display(Name = "Local")]
        Local = 1,
        [Display(Name = "Rede")]
        Rede = 2,
        [Display(Name = "NaoImprime")]
        NaoImprime = 3,

    }
}

