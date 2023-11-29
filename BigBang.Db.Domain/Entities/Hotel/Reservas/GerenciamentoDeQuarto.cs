using Db.Domain.Entities.Hotel.Quartos;
using Db.Domain.Enum.Hotel;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Db.Domain.Entities.Hotel.Reservas
{
    public class GerenciamentoDeQuarto : BaseEntityGenerico
    {
        public Reserva Reserva { get; set; }
        public int ReservaId { get; set; }
        public Quarto Quarto { get; set; }
        public int? QuartoId { get; set; }
        public StatusQuartos Status { get; set; }
        public decimal ValorAdiantamentoQuarto { get; set; }
        public decimal ValorDescontoQuarto { get; set; }
        public decimal ValorDoConsumoFinalApartamento { get; set; }
        public decimal ValorDoConsumoFinalDoCartao { get; set; }
        public DateTime DataCheckIn { get; set; }
        public DateTime DataCheckOut { get; set; }
        public string ObservacoesQuarto { get; set; }
        public decimal ValorAcrescimoQuarto { get; set; }
        public string ObservacaoDesconto { get; set; }
        public string ObservacaoAcrescimo { get; set; }
    }
}
