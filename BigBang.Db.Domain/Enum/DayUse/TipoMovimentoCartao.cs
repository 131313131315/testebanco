using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Db.Domain.Enum.DayUse
{
    public enum TipoMovimentoCartao
    {
        [Display(Name = "Carga")]
        Carga = 1,
        [Display(Name = "Recarga")]
        Recarga = 2,
        [Display(Name = "Bar")]
        Bar = 3,
        [Display(Name = "Devolucao")]
        Devolucao = 4,
        [Display(Name = "Armario")]
        Armario = 5,
        [Display(Name = "Zera Cartao")]
        ZeraCartao = 6,
        [Display(Name = "Perda")]
        Perda = 7,
        [Display(Name = "Devolucao Valor Armario")]
        DevolucaoArmario = 8,
        [Display(Name = "Transferencia Recebimento")]
        TransRecebimento = 9,
        [Display(Name = "Transferencia Negativacao")]
        TransNegativacao = 10,
        [Display(Name = "Estacionamento")]
        Estacionamento = 11,
        [Display(Name = "Estorno Armario")]
        EstornoArmario = 12,
        [Display(Name = "Envio Nota")]
        EnvioNota = 13,
        [Display(Name = "Impressao")]
        Impressao = 14
    }
}
