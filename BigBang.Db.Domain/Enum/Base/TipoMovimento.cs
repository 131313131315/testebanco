using System.ComponentModel.DataAnnotations;

namespace Db.Domain.Enum.Base
{
    public enum TipoMovimento
    {
        [Display(Name = "Hospedagem")]
        Hospedagem = 1,
        [Display(Name = "AdiantamentoReserva")]
        AdiantamentoReserva = 2,
        [Display(Name = "Retirada")]
        Retirada = 3,
        [Display(Name = "Devolucao")]
        Devolucao = 4,
        [Display(Name = "Quiosque")]
        Quiosque = 5,
        [Display(Name = "Excursao")]
        Excursao = 6,
        [Display(Name = "Passaporte")]
        Passaporte = 7,
        [Display(Name = "Carga")]
        Carga = 8,
        [Display(Name = "Recarga")]
        Recarga = 9,
        [Display(Name = "Mesas")]
        Mesas = 10,
        [Display(Name = "TrocoAdicional")]
        TrocoAdicional = 11,
        [Display(Name = "AdiantamentoHospedagem")]
        AdiantamentoHospedagem = 12,
        [Display(Name = "Estacionamento")]
        Estacionamento = 13,
        [Display(Name = "Consumo")]
        PosCarga = 14,

    }
}
