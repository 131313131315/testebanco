using System.ComponentModel.DataAnnotations;

namespace Db.Domain.Enum.DayUse
{
    public enum TipoReserva
    {
        [Display(Name = "Excursão")]
        Excursao = 1,
        [Display(Name = "Passaporte")]
        Passaporte = 2,
        [Display(Name = "Chalé")]
        Chale = 3,
        [Display(Name = "Quiosque")]
        Quiosque = 4,
        [Display(Name = "Salão de Festa")]
        SalaoFesta = 5,
        [Display(Name = "Hospedagem")]
        Hospedagem = 6
    }
}
