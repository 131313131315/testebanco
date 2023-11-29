using System.ComponentModel.DataAnnotations;

namespace Db.Domain.Enum.DayUse
{
    public enum TipoMovimentoLog
    {
        [Display(Name = "Erro Venda Bar")]
        ErroVendaBar = 1,
        [Display(Name = "Venda sem comissao")]
        VendaSemComissao = 2,
        [Display(Name = "erro front-end")]
        ErroFrontEnd = 3,
    }
}
