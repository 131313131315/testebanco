using System.ComponentModel.DataAnnotations;

namespace Db.Domain.Enum.Base
{
    public enum TipoSexo
    {
        [Display(Name = "Feminino")]
        Feminino = 1,
        [Display(Name = "Masculino")]
        Masculino = 2,
        [Display(Name = "Outros")]
        Outros = 3
    }
}
