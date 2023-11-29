using System.ComponentModel.DataAnnotations;

namespace Db.Domain.Enum.DayUse
{
    public enum TipoEspaco
    {
        [Display(Name = "Salão de Festa")]
        SalaoFesta = 1,
        [Display(Name = "Quiosque")]
        Quiosque = 2,        
        [Display(Name = "Quadra Jogos")]
        QuadraJogos = 3,
        [Display(Name = "Salão de Jogos")]
        SalaoJogos = 4,
        [Display(Name = "Outros")]
        Outros = 5
    }
}
