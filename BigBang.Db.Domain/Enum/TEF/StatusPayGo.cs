using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Db.Domain.Enum.TEF
{
    public enum StatusIntencaoVendaPayGo
    {
        [Display(Name = " Transação pendente de pagamento. Somente foi criada e não iniciou nenhum fluxo de pagamento ainda")]
        Pendente = 5,
        [Display(Name = "Transação que já iniciou um processo de pagamento")]
        EmPagamento = 6,
        [Display(Name = "Pagamento aprovado")]
        Creditado = 10,
        [Display(Name = " Se é solicitado o iniciar pagamento automático e não for possível inicia-lo, a transação fica com status de expirado após 15 segundos")]
        Expirado = 15,
        [Display(Name = "Solicitado o processo de cancelamento")]
        CancelamentoIniciado = 18,
        [Display(Name = "Sistema de pagamento recebeu a solicitação de cancelamento")]
        EmCancelamento = 19,
        [Display(Name = "Cancelamento concluído")]
        Cancelado = 20,
        [Display(Name = "Pagamento não aprovado pela adquirente ou banco emissor.")]
        PagamentoRecusado = 25,
        [Display(Name = "TimeOut Falha na comunicao")]
        TimeOut = 99
    }
}
