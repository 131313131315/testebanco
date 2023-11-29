using Db.Domain.Entities.Cadastros.DayUse.Cartao;
using Db.Domain.Enum.Base.NotaFiscal;
using Domain.Entities;
using Domain.Entities.Cadastros.Empresa;
using Domain.Entities.Cadastros.PessoaJuridicaFisica;
using System;

namespace Db.Domain.Entities.Base.NotaFiscal
{
    public class NotaFiscalNfce : BaseEntityGenerico
    {
        public Empresas Empresa { get; set; }
        public int EmpresaId { get; set; }
        public Pessoa Pessoa { get; set; }
        public int? PessoaId { get; set; }
        public MovimentacaoCartaoConsumo MovimentacaoCartaoConsumo { get; set; }
        public int? MovimentacaoCartaoConsumoId { get; set; }
        public DateTime DataLancamento { get; set; }
        public DateTime? DataEnvio { get; set; }
        public string ChaveAcesso { get; set; }
        public StatusNotaFiscal StatusNota { get; set; }
        public int NumeroNota { get; set; }
        public bool Contingencia { get; set; }
        public string InformacaoErro { get; set; }
        public string MotivoSefaz { get; set; }
        public TipoAmbienteNFCe Ambiente { get; set; }
        public decimal ValorNota { get; set; }
        public string Protocolo { get; set; }
        public string ProtocoloInutilizado { get; set; }
        public string ProtocoloCancelado { get; set; }
        public string CpfCnpj { get; set; }
    }
}
