using Db.Domain.Entities.Cadastros.Base;
using Db.Domain.Enum.DayUse;
using Domain.Entities;
using Domain.Entities.Cadastros.PessoaJuridicaFisica;
using System;

namespace Db.Domain.Entities.Cadastros.DayUse.Passaportes
{
    public class Passaporte : BaseEntityGenerico
    {
        // falta excursao 
        public int? CaixaId { get; set; }
      
        public int? PessoaId { get; set; }
        public Pessoa Pessoa { get; set; }
        public int UsuarioId { get; set; }
        public ApplicationUser Usuario { get; set; }
        public bool Impresso { get; set; }
        public string? NumeroPassaporte { get; set; }
        private DateTime? _dataCriacao;
        public DateTime? DataCriacao
        {
            get { return _dataCriacao; }
            set { _dataCriacao = (value == null ? DateTime.Now : value); }
        }
        public DateTime? DataValidade { get; set; }
        public DateTime? DataEntrada { get; set; }
        public TipoPessoaPark TipoPassaporte { get; set; }
        public decimal Valor { get; set; }
        public string Voucher { get; set; }
        public int? PassaportePromocaoId { get; set; }
        public PassaportePromocao PassaportePromocao { get; set; }
        public string? NumeroTituloCota { get; set; }
        public SituacaoPassaporte Situacao { get; set; }
        public int? ExcursaoId { get; set; }
    }
}
