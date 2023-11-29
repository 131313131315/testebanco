using Db.Domain.Entities.Cadastros.Base;
using Db.Domain.Entities.Hotel.Reservas;
using Db.Domain.Enum.Hotel;
using Domain.Entities;
using Domain.Entities.Cadastros.PessoaJuridicaFisica;
using Domain.Entities.Cadastros.Produto;
using System;

namespace Db.Domain.Entities.Hotel.Quartos
{
    public class ConsumoQuarto : BaseEntityGenerico
    {

        public int Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }
        public decimal ValorTotal { get; set; }
        public SituacaoConsumoQuarto Situacao { get; set; }
        public DateTime DataCadastro { get; set; }
        public produto Item { get; set; }
        public int ItemId { get; set; }
        public Reserva Reserva { get; set; }
        public int ReservaId { get; set; }
        public ApplicationUser Usuario { get; set; }
        public int UsuarioId { get; set; }
        public Quarto Quarto { get; set; }
        public int QuartoId { get; set; }



    }
}
