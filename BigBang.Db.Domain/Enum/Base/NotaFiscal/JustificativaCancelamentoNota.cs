using System.ComponentModel.DataAnnotations;

namespace Db.Domain.Enum.Base.NotaFiscal
{
    public enum JustificativaCancelamentoNota
    {
        [Display(Name = "Desistencia do Comprador")]
        DesistenciaComprador = 1,
        [Display(Name = "Cancelamento da Vendas")]
        CancelamentoVendas = 2,
        [Display(Name = "Calculos de precos e impostos incorretos")]
        CalculoIncorreto = 3,
        [Display(Name = "Erros cadastrais")]
        ErroCadastral = 4,
    }
}
