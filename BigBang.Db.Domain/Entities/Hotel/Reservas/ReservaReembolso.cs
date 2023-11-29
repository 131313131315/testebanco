using Db.Domain.Entities.Cadastros;
using Db.Domain.Entities.Cadastros.Base;
using Db.Domain.Enum;
using Db.Domain.Enum.Hotel;
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
    public class ReservaReembolso : BaseEntityGenerico
    {
        public Pessoa Titular { get; set; }
        
        public int TitularId { get; set; }

        public Reserva Reserva { get; set; }
        
        public int ReservaId { get; set; }

        public ApplicationUser Usuario { get; set; }
        public int UsuarioId { get; set; }

        public decimal ValorPagoReserva { get; set; }
        
        public decimal ValorDevolvido { get; set; }
        
        public decimal ValorReserva { get; set; }
       
        public DateTime DataSolicitacao { get; set; }
       
        public DateTime DataPrevisaoPagamento { get; set; }
       
        public DateTime DataPagamento { get; set; }
        
        public Banco Banco { get; set; }
        
        public TipoConta TipoConta { get; set; }
        
        public string Agencia { get; set; }
        
        public string Conta { get; set; }
        
        public string Operacao { get; set; }
        
        public string Comprovante { get; set; }
        
        public SituacaoReembolso Status { get; set; }

    }
}
