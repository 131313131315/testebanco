using Api.Domain.Entities;
using Db.Domain.Entities.Cadastros.Base;
using Db.Domain.Enum.DayUse;
using Domain.Entities;
using Domain.Entities.Cadastros.PessoaJuridicaFisica;
using System;

namespace Db.Domain.Entities.DayUse
{
    public class Excursao : BaseEntity
    {
        public int PessoaId { get; set; }
        public Pessoa Pessoa { get; set; }
        public int UsuarioVendaId { get; set; }
        public ApplicationUser UsuarioVenda { get; set; }
        public int? AgenciaId { get; set; }
        public Pessoa Agencia { get; set; }
        public DateTime DataExcursao { get; set; }
        public DateTime DataCadastro { get; set; }
        public decimal ValorTotal { get; set; }
        public decimal? ValorRecebido { get; set; }
        public decimal? ValorDesconto { get; set; }
        public decimal ValorLiquido { get; set; }
        public string Observacao { get; set; }
        public bool Confirmado { get; set; }        
        public int? UsuarioRecebimentoId { get; set; }
        public int? QuantidadeParcelas { get; set; }
        public int? VoucherPassaporte { get; set; }
        public ApplicationUser UsuarioRecebimento { get; set; }        
        public TipoVendaPark TipoVenda { get; set; }
    }
}
