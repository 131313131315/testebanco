using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Db.Domain.Enum.TEF
{
    public enum FormaPagamentoPayGo
    {
        [Display(Name = "Credito")]
        TEF_Crédito = 21,
        [Display(Name = "Debito")]
        TEF_Débito = 22,
        [Display(Name = "Voucher")]
        TEF_Voucher = 23,
        [Display(Name = "Nada é enviado e o operador do caixa informará de acordo com as opções que o adquirente disponibilizar")]
        TEF_Outros = 24,
        [Display(Name = "URL do gateways de pagamento é devolvdido para redirecionar o usuário")]
        Cartao_de_credito_digitado = 51
    }
}
