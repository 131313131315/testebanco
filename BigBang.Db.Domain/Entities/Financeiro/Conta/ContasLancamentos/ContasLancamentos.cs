using Api.Domain.Entities;
using Db.Domain.Entities.Financeiro.Conta;
using Db.Domain.Enum;
using Domain.Entities.Cadastros.Empresa;
using Domain.Entities.Cadastros.PessoaJuridicaFisica;
using System;

namespace Db.Domain.Entities.Cadastros
{
    public class ContasLancamentos : BaseEntity
    {
        public string Descricao { get; set; }
        public CategoriaContas CategoriaContas { get; set; }
        public int? CategoriaContasId { get; set; }
        public ContaBancaria ContaBancaria { get; set; }
        public int ContaBancariaId { get; set; }
        public Pessoa ClienteFornecedor { get; set; }
        public int? ClienteFornecedorId { get; set; }
        public CentroCusto CentroCusto { get; set; }
        public int? CentroCustoId { get; set; }
        public Empresas Empresa { get; set; }
        public int EmpresaId { get; set; }
        public DateTime DataCompetencia { get; set; }
        public DateTime DataVencimento { get; set; }
        public DateTime? DataPagamento { get; set; }
        public decimal Valor { get; set; }
        public decimal ValorDescontos { get; set; }
        public decimal ValorJuros { get; set; }
        public decimal ValorPago { get; set; }
        public decimal ValorBanco { get; set; }
        public bool Conciliado { get; set; }
        public string Observacao { get; set; }
        public TipoLancamentoContas TipoLancamento { get; set; }
        public string Parcela { get; set; }
        public TransferenciaBancaria TransferenciaBancaria { get; set; }
        public int? TransferenciaBancariaId { get; set; }
        public decimal? Saldo { get; set; }
        public DateTime? DataSaldo { get; set; }
        public ContasLancamentos ContaParcial { get; set; }
        public int? ContaParcialId { get; set; }
    }
}
