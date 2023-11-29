using Db.Domain.Entities.Cadastros.DayUse.Cartao;
using Db.Domain.Entities.Hotel.Reservas;
using Domain.Entities;
using Domain.Entities.Cadastros.PessoaJuridicaFisica;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Db.Domain.Entities.Hotel.Hospede
{
    public class CartaoHospede : BaseEntityGenerico
    {
        public Reserva Reserva { get; set; }
        public int ReservaId { get; set; }
        public CartaoConsumo CartaoConsumo { get; set; }
        public int CartaoConsumoId { get; set; }
        public Pessoa Hospede { get; set; }
        public int HospedeId { get; set; }
    }
}
