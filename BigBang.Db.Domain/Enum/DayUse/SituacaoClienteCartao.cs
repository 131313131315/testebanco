using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Db.Domain.Enum.DayUse
{

    public enum SituacaoClienteCartao
    {
        [Display(Name = "Em-uso")]
        Em_Uso = 1,
        [Display(Name = "Pago")]
        Pago = 2,
        [Display(Name = "Nao-Pago")]
        NaoPago = 3,
        [Display(Name = "Inativo")]
        Inativo = 4,

    }
}
