using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Db.Domain.Enum.DayUse
{
    public enum TipoPessoaPark
    {
        [Display(Name = "Adulto")]
        Adulto = 1,
        [Display(Name = "Criança")]
        Crianca = 2,
        [Display(Name = "Senior")]
        Senior = 3,
        [Display(Name = "Cortesia Adicional")]
        CortesiaAdicional = 4,
        [Display(Name = "Cortesia")]
        Cortesia = 5,
        [Display(Name = "Vendas Internet")]
        VendasInternet = 6,
        [Display(Name = "Funcionario")]
        Funcionario = 7,
        [Display(Name = "Cortesia Cliente")]
        CortesiaCliente = 8
    }
}
