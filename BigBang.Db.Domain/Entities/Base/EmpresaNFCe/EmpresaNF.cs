using Api.Domain.Entities;
using Db.Domain.Enum.Base.NotaFiscal;
using Domain.Entities.Cadastros.Empresa;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Cadastros.EmpresaNFs
{
    public class EmpresaNF : BaseEntity
    {
        public int EmpresaId { get; set; }
        public Empresas Empresa { get; set; }
        public int EmpresaNotaId { get; set; }
        public TipoAmbienteNFCe TipoAmbiente { get; set; }
        public string Certificado { get; set; }
        public string IdTokenHomologacao { get; set; }
        public string IdTokenProducao { get; set; }
        public string CscHomologacao { get; set; }
        public string CscProducao { get; set; }
        public string Crt { get; set; }        
        public string SerieNota { get; set; }
        public string SenhaCertificado { get; set; }
    }
}
