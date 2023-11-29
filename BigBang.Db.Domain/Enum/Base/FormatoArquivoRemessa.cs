using System.ComponentModel.DataAnnotations;

namespace Db.Domain.Enum.Base
{
    public enum FormatoArquivoRemessa
    {
        [Display(Name = "Cnab400")]
        Cnab400 = 1,
        [Display(Name = "Cnab240")]
        Cnab240 = 2
    }
}
