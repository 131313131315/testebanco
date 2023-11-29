using Domain.Entities;

namespace Db.Domain.Entities.Base.NotaFiscal
{
    public class ParametrosNotaFiscal : BaseEntityGenerico
    {
        public string WebServiceUf { get; set; }
        public string FusoHorario { get; set; }
        public string ArquivoHomologacao { get; set; }
        public string ArquivoProducao { get; set; }
        public string DiretorioEsquemas { get; set; }
        public string DiretorioTemplate { get; set; }
        public string DiretorioLog { get; set; }
        public string DiretorioLogErro { get; set; }
        public string DiretorioTemporario { get; set; }
        public string DiretorioXmlDestinatario { get; set; }
        public string DiretorioSalvarXmlHomologacao { get; set; }
        public string DiretorioSalvarXmlProducao { get; set; }
        public string DiretorioSalvarPdf { get; set; }
        public string DiretorioNotasRaiz { get; set; }
        public string DiretorioNotasZipe { get; set; }
        public string DiretorioNotasAutorizado { get; set; }
        public string DiretorioNotasContigencia { get; set; }
        public string DiretorioNotasInutilizada { get; set; }
        public string DiretorioNotasCancelados { get; set; }
        public string DiretorioCertificado { get; set; }
    }
}
