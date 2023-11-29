using Api.Domain.Entities;
using Db.Domain.Entities.Cadastros.Base;
using Db.Domain.Enum.Base;
using Db.Domain.Enum.Financeiro;
using Domain.Entities;
using Domain.Entities.Cadastros.Empresa;
using Domain.Entities.Cadastros.PessoaJuridicaFisica;
using System;

namespace Db.Domain.Entities.Base.PessoaJuridicaFisica
{
    public class PessoaCreditoDebito : BaseEntity
    {
        public int PessoaId { get; set; }
        public Pessoa Pessoa { get; set; }
        public decimal Valor { get; set; }
        public TipoLancamentoPessoa TipoLancamento { get; set; }
        public DestinoCreditoDebito DestinoCreditoDebito { get; set; }
        public int EmpresaId { get; set; }
        public Empresas Empresa { get; set; }
        public DateTime DataValidade { get; set; }
        public int UsuarioId { get; set; }
        public ApplicationUser Usuario { get; set; }
        public int? UsuarioUtilizouId { get; set; }
        public ApplicationUser UsuarioUtilizou { get; set; }
        public DateTime? DataPagamento { get; set; }
        public string Observacao { get; set; }        
    }
}
