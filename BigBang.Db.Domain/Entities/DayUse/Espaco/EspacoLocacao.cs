using Db.Domain.Entities.Cadastros.Base;
using Db.Domain.Entities.DayUse;
using Db.Domain.Enum.DayUse;
using Domain.Entities;
using Domain.Entities.Cadastros.PessoaJuridicaFisica;
using System;

namespace Db.Domain.Entities.Cadastros.DayUse
{
    public class EspacoLocacao : BaseEntityGenerico
    {
        public int EspacoId { get; set; }
        public Espaco Espaco { get; set; }
        public int PessoaId { get; set; }
        public Pessoa Pessoa { get; set; }

        public int? UsuarioRecebimentoId { get; set; }
        public ApplicationUser UsuarioRecebimento { get; set; }
        public int UsuarioId { get; set; }
        public ApplicationUser Usuario { get; set; }
        public DateTime DataLocacao { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime? DataPagamento { get; set; }
        public SituacaoLocacao SituacaoLocacao { get; set; }
        public decimal Valor { get; set; }
        public decimal? ValorPago { get; set; }       
        public int? NumeroTitulo { get; set; }
        public int? NumeroAlteracaoData { get; set; }
        public int Identificador { get; set; }
        public string IdentificadorAntes { get; set; }
        public bool? Camping { get; set; }
        public bool? ReservaSocio { get; set; }
        public int? ExcursaoId { get; set; }
        public Excursao Excursao { get; set; }
        public string? Observacao { get; set; }

    }
}
