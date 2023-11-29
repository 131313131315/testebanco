using Db.Domain.Entities.Hotel.Quartos;
using Db.Domain.Entities.Hotel.Reservas;
using Domain.Entities;
using Domain.Entities.Cadastros.PessoaJuridicaFisica;
using System;

namespace Db.Domain.Entities.Hotel.Refeicao
{

    public class RefeicaoConsumo : BaseEntityGenerico
    {
        public Reserva Reserva { get; set; }
        public int? ReservaId { get; set; }
        public Quarto Quarto { get; set; }
        public int? QuartoId { get; set; }
        public Pessoa Hospede { get; set; }
        public int HospedeId { get; set; }
        public RefeicaoPreco RefeicaoPreco { get; set; }
        public int RefeicaoPrecoId { get; set; }
        public DateTime DataConsumo { get; set; }
        public DateTime DataConsumido { get; set; }
        



    }
}
