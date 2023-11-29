using Api.Domain.Entities;
using Db.Domain.Entities.Cadastros;
using Domain.Entities.Cadastros.Empresa;
using System;

namespace Db.Domain.Entities.Financeiro.Conta
{
    public class TransferenciaBancaria : BaseEntity
    {
        public Empresas Empresa { get; set; }
        public int EmpresaId { get; set; }
        public string Descricao { get; set; }
        public ContaBancaria ContaOrigem { get; set; }
        public int ContaOrigemId { get; set; }
        public ContaBancaria ContaDestino { get; set; }
        public int ContaDestinoId { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataTranferencia { get; set; }
    }
}
