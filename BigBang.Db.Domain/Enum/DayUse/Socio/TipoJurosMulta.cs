using System.ComponentModel.DataAnnotations;

namespace Db.Domain.Enum.Base.Socio
{
    public enum TipoJurosMulta
    {
        [Display(Name = "%")]
        Porcentagem = 1,
        [Display(Name = "R$")]
        Dinheiro = 2
    }
}
