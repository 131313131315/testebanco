using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Db.Domain.Enum.DayUse
{
    public enum TipoAutomacao
    {
        [Display(Name = "Armario")]
        Armario = 1,
        [Display(Name = "Catracas")]
        Catracas = 2,
        [Display(Name = "Recarga")]
        Recarga = 3,
        [Display(Name = "Jogos")]
        Jogos = 4,
        [Display(Name = "Beer")]
        Beer = 5,
    }
}
