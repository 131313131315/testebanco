using Db.Domain.Entities.Cadastros.DayUse;
using Db.Domain.Entities.Cadastros.DayUse.Cartao;
using Db.Domain.Enum.DayUse;
using Domain.Entities;
using Domain.Entities.Cadastros.PessoaJuridicaFisica;
using System;
using System.Collections.Generic;
using System.Text;

namespace Db.Domain.Entities.DayUse.CartaoConsumoPark
{
    public class CartaoConsumoCliente : BaseEntityGenerico
    {
        public DateTime DataLancamento { get; set; }
        public int? CartaoConsumoId { get; set; }
        public CartaoConsumo CartaoConsumo { get; set; }
        public int? PessoaId { get; set; }
        public Pessoa Pessoa { get; set; }
        public int? ClientePagoId { get; set; }
        public CartaoConsumoClientePago ClientePago { get; set; }
        public int? EmpresaId { get; set; }        
        public int? NumeroComprovante { get; set; }
        public string Observacao { get; set; }
        public SituacaoCatraca? Liberado { get; set; }
        public int? PassaportePromocaoId { get; set; }
        public PassaportePromocao PassaportePromocao { get; set; }
        public int? CaixaId { get; set; }
        public int? IdExcursao { get; set; }
        public TipoPessoaPark? TipoPassaporte { get; set; }
        public SituacaoClienteCartao? Situacao { get; set; }
        public bool? Refeicao { get; set; }
        public decimal? CreditoRefeicao { get; set; }
    }
}
