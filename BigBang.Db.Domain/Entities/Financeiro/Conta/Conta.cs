using Api.Domain.Entities;
using Db.Domain.Enum;
using Domain.Enum;
using System;

namespace Db.Domain.Entities.Cadastros
{
    public class Conta : BaseEntity
    {
        public string Descricao { get; set; }
        public TipoContaPessoa? TipoPessoa { get; set; }
        public TipoConta TipoConta { get; set; }
        public bool Padrao { get; set; }
        public decimal Saldo { get; set; }
        public DateTime DataSaldo { get; set; }
        public int BancoId { get; set; }
        public Bancos Banco { get; set; }
        public int? ContaCorrenteVinculada { get; set; }
        public TipoCartao? TipoCartao { get; set; }
        public DateTime? DataFechamento { get; set; }
        public DateTime? DataVencimento { get; set; }
        public string Cartao { get; set; }
    }
}