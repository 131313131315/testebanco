using Db.Domain.Entities.Cadastros.Base;
using Db.Domain.Enum.Hotel;
using Domain.Entities.Cadastros.PessoaJuridicaFisica;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Db.Domain.Entities.Hotel.Reservas
{
    public class Reserva : BaseEntityGenerico
    {

        public ApplicationUser Usuario { get; set; }
        public int UsuarioId { get; set; }
        public Pessoa Titular { get; set; }
        public int TitularId { get; set; }
        public Pessoa Agencia { get; set; }
        public int? AgenciaId { get; set; }
        public decimal ValorBruto { get; set; }
        public decimal ValorDoDesconto { get; set; }
        public decimal ValorLiquido { get; set; }
        public decimal ValorPago { get; set; }
        public decimal ValorDeAcrescimo { get; set; }
        public decimal ValorDeCreditosAnteriores { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataSaida { get; set; }
        public DateTime DataCadastro { get; set; }
        public int QuantidadeDeAdultos { get; set; }
        public int QuantidadeDeCriancas { get; set; }
        public DateTime? DataHoraDoCheckIn { get; set; }
        public DateTime? DataHoraDoCheckOut { get; set; }
        public DateTime? DataAlteracao { get; set; }
        public virtual StatusQuartos Status { get; set; }
        public virtual TipodeReserva Tipo { get; set; }
        public string Observacao { get; set; }
        public string ObservacaoCheckin { get; set; }
        public string Veiculo { get; set; }
        public int NumeroRazao { get; set; }
        public decimal ValorDoEstorno { get; set; }
        public DateTime? DataDoCancelamento { get; set; }
        public int? IdUsuarioEfetuouCheckin { get; set; }
        public int? IdUsuarioEfetuouCheckout { get; set; }
    }
}
