using System.ComponentModel.DataAnnotations;

namespace Domain.Enum
{
    public enum TipoRegimeTributario
    {
        [Display(Name = "MEI")]
        Mei = 1,
        [Display(Name = "SIMPLES NACIONAL")]
        SimplesNacional = 2,
        [Display(Name = "LUCRO REAL")]
        LucroReal = 3,
        [Display(Name = "LUCRO PRESUMIDO")]
        LucroPresumido = 4
    }
}
