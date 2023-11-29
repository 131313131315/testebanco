
using Db.Domain.Entities.Hotel.Quartos;
using Domain.Entities;
using Domain.Entities.Cadastros.PessoaJuridicaFisica;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Db.Domain.Entities.Hotel.Reservas
{
    public class GerenciamentoDeReserva : BaseEntityGenerico
    {
        public Reserva Reserva { get; set; }
        public int ReservaId { get; set; }
        public Quarto Quarto { get; set; }
        public int? QuartoId { get; set; }
        public Pessoa Hospede { get; set; }
        public int? HospedeId { get; set; }
    }
}
