using System.ComponentModel.DataAnnotations;

namespace Db.Domain.Enum
{
    public enum TipoCategoriaContas
    {
        [Display(Name = "Receita")]
        Receita = 1,
        [Display(Name = "Despesa")]
        Despesa = 2
    }
}

