using Api.Domain.Entities;
using Db.Domain.Enum.Base;
using Db.Domain.Enum.Base.Socio;
using Db.Domain.Enum.Financeiro;
using Domain.Entities.Cadastros.Empresa;

namespace Db.Domain.Entities.Cadastros
{
    public class Cobradores : BaseEntity
    {
        public string Descricao { get; set; }
        public ContaBancaria Conta { get; set; }
        public int ContaId { get; set; }
        public Empresas Empresa { get; set; }
        public int EmpresaId { get; set; }
        public string CodigoBeneficiario { get; set; }
        public string DigitoBeneficiario { get; set; }
        public string NossoNumeroUltimo { get; set; }
        public string NumeroDocumentoUltimo { get; set; }
        public TipoCarteiraCobranca CarteiraCobranca { get; set; }
        public TipoEspecie TipoEspecie { get; set; }
        public TituloDocEspecie TituloDocEspecie { get; set; }
        public FormatoArquivoRemessa FormatoArquivoRemessa { get; set; }
        public TipoJurosMulta TipoJuros { get; set; }
        public TipoJurosMulta TipoMulta { get; set; }
        public TipoJurosMulta TipoDesconto { get; set; }
        public decimal PercentualMulta { get; set; }
        public decimal PercentualJuros { get; set; }
        public decimal PercentualDesconto { get; set; }
        public int QuantidadeDiasDescontos { get; set; }
        public string LocalPagamento { get; set; }
        public string InstrucaoCobranca { get; set; }
        public string CodigoMovimento { get; set; }
        public string DescricaoMovimento { get; set; }
        public string NumeroControleParticipante { get; set; }
        public string Aceite { get; set; }
        public int CodigoProtesto { get; set; }
        public int QuantidadeDiasProtesto { get; set; }
        public int QuantidadeDiasBaixaDevolucao { get; set; }
        public int CodigoBaixaDevolucao { get; set; }
        public bool ImprimirValoresAuxiliares { get; set; }
        public string CarteiraPadrao { get; set; }
        public string VariacaoCarteiraPadrao { get; set; }
        public string CodigoTransmissao { get; set; }
    }
}
