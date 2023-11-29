using System.ComponentModel.DataAnnotations;

namespace Domain.Enum
{
    public enum TipoContaPessoa
    {
        [Display(Name = "Fisica")]
        Fisica = 1,
        [Display(Name = "Juridica")]
        Juridica = 2,
    }
}
