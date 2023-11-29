using System.ComponentModel.DataAnnotations;

namespace Db.Domain.Enum.Base
{
    public enum TipoEspecie
    {
        [Display(Name = "Real")]
        Real = 1,
        [Display(Name = "Guarani")]
        Guarani = 2,
        [Display(Name = "Dolar")]
        Dolar = 3
    }
}
