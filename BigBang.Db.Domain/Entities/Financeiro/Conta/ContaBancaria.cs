using Api.Domain.Entities;
using Db.Domain.Entities.Financeiro.Bandeira;
using Db.Domain.Enum;
using Domain.Entities.Cadastros.Empresa;
using Domain.Enum;
using System;

namespace Db.Domain.Entities.Cadastros
{
    public class ContaBancaria : BaseEntity
    {
        public string Descricao { get; set; }
        public string Agencia { get; set; }
        public string DigitoAgencia { get; set; }
        public string NumeroConta { get; set; }
        public string DigitoConta { get; set; }
        public TipoContaPessoa? TipoPessoa { get; set; }
        public TipoConta TipoConta { get; set; }
        public bool Padrao { get; set; }
        public decimal Saldo { get; set; }
        public DateTime DataSaldo { get; set; }
        public int BancoId { get; set; }
        public Bancos Banco { get; set; }
        public ContaBancaria ContaCorrenteVinculada { get; set; }
        public int? ContaCorrenteVinculadaId { get; set; }
        public TipoCartao? TipoCartao { get; set; }
        public DateTime? DataFechamento { get; set; }
        public DateTime? DataVencimento { get; set; }
        public string Cartao { get; set; }
        public Bandeira Bandeira { get; set; }
        public int? BandeiraId { get; set; }
        public Empresas Empresa { get; set; }
        public int EmpresaId { get; set; }
    }
}