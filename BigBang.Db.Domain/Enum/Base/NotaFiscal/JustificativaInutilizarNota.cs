using System.ComponentModel.DataAnnotations;

namespace Db.Domain.Enum.Base.NotaFiscal
{
    public enum JustificativaInutilizarNota
    {
        [Display(Name = "Numeração não existente")]
        NumeracaoInexistente = 1,
        [Display(Name = "Falha Validação de Dados")]
        FalhaValidacao = 2,
        [Display(Name = "Informado o NCM Incorreto")]
        NcmIncorreto = 3,
    }
}
