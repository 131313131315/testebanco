using System.ComponentModel.DataAnnotations;

namespace Domain.Enum
{
    public enum TipoEndereco
    {
        [Display(Name = "Principal")]
        Principal = 1,
        [Display(Name = "Cobrança")]
        Cobrança = 2,
        [Display(Name = "Responsável")]
        Responsavel = 3
    }
}
