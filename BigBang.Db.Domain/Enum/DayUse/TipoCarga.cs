using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Db.Domain.Enum.DayUse
{
    public enum TipoCarga
    {
        [Display(Name = "PrePago")]
        PrePago = 1,
        [Display(Name = "PosPago")]
        PosPago = 2,        
    }
}
