using System.ComponentModel.DataAnnotations;

namespace Domain.Enum
{
    public enum TipoEmpresa
    {
        [Display(Name = "Hotel")]
        Hotel = 1,
        [Display(Name = "Restaurante")]
        Restaurante = 2,
        [Display(Name = "Bar")]
        Bar = 3,
        [Display(Name = "Agencia")]
        Agencia = 4,
        [Display(Name = "Lanchonete")]
        Lanchonete = 5,
        [Display(Name = "Diversao")]
        Diversao = 6,
        [Display(Name = "Conveniencia")]
        Conveniencia = 7,
        [Display(Name = "Outros")]
        Outros = 8,
        [Display(Name = "Administracao")]
        Administracao = 9
    }
}
