using Api.Domain.Entities;
using Db.Domain.Enum.Financeiro;
using Domain.Entities.Cadastros.Empresa;
using Domain.Entities.Cadastros.PessoaJuridicaFisica;
using System;

namespace Db.Domain.Entities.Financeiro.Boleto
{
    public class Boletos : BaseEntity
    {
        public Pessoa Pessoa { get; set; }
        public int PessoaId { get; set; }
        public Empresas Empresa { get; set; }
        public int EmpresaId { get; set; }
        public string NossoNumero { get; set; }
        public string NumeroDocumento { get; set; }
        public decimal ValorDocumento { get; set; }
        public decimal ValorJurosMulta { get; set; }
        public decimal ValorPago { get; set; }
        public string CodigoBeneficiario { get; set; }
        public DateTime DataVencimento { get; set; }
        public DateTime DataEmissao { get; set; }
        public TipoBoleto TipoBoleto { get; set; }
        public bool Pago { get; set; }
        public decimal ValorTarifas { get; set; }
    }
}
