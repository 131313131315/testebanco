using System.ComponentModel.DataAnnotations;

namespace Domain.Enum
{
    public enum TipoTelefone
    {
        [Display(Name = "Celular")]
        Celular = 1,
        [Display(Name = "Fixo")]
        Fixo = 2,
        [Display(Name = "Comercial")]
        Comercial = 3
    }
}
