using System.ComponentModel.DataAnnotations;

namespace Db.Domain.Enum.Base
{
    public enum TipoPessoa
    {
        [Display(Name = "Cliente")]
        Cliente = 1,
        [Display(Name = "Fornecedor")]
        Fornecedor = 2,
        [Display(Name = "Hospede")]
        Hospede = 3,
        [Display(Name = "Empresa")]
        Empresa = 4,
        [Display(Name = "Agencia")]
        Agencia = 5,
        [Display(Name = "Escola")]
        Escola = 6,
        [Display(Name = "Sócio")]
        Socio = 7,
        [Display(Name = "Ex-Sócio")]
        ExSocio = 8,
    }
}
