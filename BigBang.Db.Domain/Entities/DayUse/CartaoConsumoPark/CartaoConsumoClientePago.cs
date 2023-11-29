using Db.Domain.Entities.Cadastros.DayUse.Cartao;
using Db.Domain.Enum.DayUse;
using Domain.Entities.Cadastros.PessoaJuridicaFisica;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Api.Domain.Entities;

namespace Db.Domain.Entities.DayUse.CartaoConsumoPark
{
    public class CartaoConsumoClientePago : BaseEntity
    {
        public DateTime DataLancamento { get; set; }
        public int? PessoaId { get; set; }
        public Pessoa Pessoa { get; set; }
        
        public decimal? Gasto { get; set; }
        public decimal? Adiantamento { get; set; }
        public decimal? Pago { get; set; }
        public decimal? Recebido { get; set; }

        public string Cartoes { get; set; }
        public int? Comprovante { get; set; }
        public TipoPessoaPark? TipoPassaporte { get; set; }

    }
}

