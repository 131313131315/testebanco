using System.ComponentModel.DataAnnotations;

namespace Domain.Enum
{
    public enum TipoItem
    {
        [Display(Name = "Produto")]
        Produto = 1,
        [Display(Name = "Servico")]
        Servico = 2
    }
}
