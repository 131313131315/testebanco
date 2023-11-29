using System.ComponentModel.DataAnnotations;

namespace Domain.Enum
{
    public enum OperadoraTelefonia
    {
        [Display(Name = "CLARO/NET")]
        CLARO = 1,
        [Display(Name = "CTBC Telecom")]
        CTBC = 2,
        [Display(Name = "Nextel")]
        NEXTEL = 3,
        [Display(Name = "Sercomtel")]
        SERCOMTEL = 4,
        [Display(Name = "Tim")]
        TIM = 5,
        [Display(Name = "Vivo/Telefonica")]
        VIVO = 6,
        [Display(Name = "Oi")]
        OI = 7,
        [Display(Name = "Outras")]
        OUTRAS = 8
    }
}
