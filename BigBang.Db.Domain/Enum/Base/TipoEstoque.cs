using System.ComponentModel.DataAnnotations;

namespace Domain.Enum
{
    public enum TipoEstoque
    {
        [Display(Name = "FIFO")]
        FIFO = 1,
        [Display(Name = "LIFO")]
        LIFO = 2,
        [Display(Name = "FEFO")]
        FEFO = 3
    }
}
