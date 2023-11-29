using System.ComponentModel.DataAnnotations;

namespace Db.Domain.Enum.Hotel
{
    public enum StatusQuartos
    {
        [Display(Name = "Livre")]
        Livre = 0,
        [Display(Name = "Limpeza")]
        Limpeza = 1,
        [Display(Name = "Manutenção")]
        Manutenção = 2,
        [Display(Name = "Quarto bloqueado Para reserva")]
        Bloqueado_para_reserva = 3,
        [Display(Name = "Reserva Parciamente Confirmada")]
        Parcialmente_confirmado = 4,
        [Display(Name = "CheckIn")]
        CheckIn = 5,
        [Display(Name = "No Show")]
        No_Show = 6,
        [Display(Name = "Reservado")]
        Reservado = 10,
        [Display(Name = "Reserva Confirmada")]
        Reserva_confirmada = 11,
        [Display(Name = "Ocupado")]
        Ocupado = 12,
        [Display(Name = "Vencido")]
        Vencido = 13,
        [Display(Name = "Finalizado")]
        Finalizado = 14,
        [Display(Name = "Reserva Cancelada")]
        Cancelado = 15,
        [Display(Name = "Crédito")]
        Credito = 16,
        [Display(Name = "Confirmada pelo Gerente")]
        Reserva_confirmada_gerente = 17,
        [Display(Name = "Finalizado com crédito")]
        Finalizado_Credito = 18,
        [Display(Name = "Baixa não confirmada")]
        Baixa_nao_confirmado = 19,
    }
}
