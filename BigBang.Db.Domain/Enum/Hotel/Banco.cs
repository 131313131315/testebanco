using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Db.Domain.Enum.Hotel
{
    public enum Banco
    {
        [Display(Name = "Banco do Brasil")]
        BANCO_BRASIL,
        [Display(Name = "Caixa Econômica")]
        CAIXA_ECONOMICA,
        [Display(Name = "Itaú")]
        ITAU,
        [Display(Name = "Bradesco")]
        BRADESCO,
        [Display(Name = "Santander")]
        SANTANDER,
        [Display(Name = "Sicoob")]
        SICOOB,
        [Display(Name = "Sicred")]
        SICRED,
        [Display(Name = "Banco Safra")]
        SAFRA,
        [Display(Name = "CitiBank")]
        CITIBANK

    }
}
