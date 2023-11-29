using Api.Domain.Entities;
using Db.Domain.Enum.DayUse.Socio;
using Domain.Entities.Cadastros.PessoaJuridicaFisica;

namespace Db.Domain.Entities.Socio.SocioCobranca
{
    public class SocioCobranca : BaseEntity
    {
        public Pessoa Socio { get; set; }
        public int SocioId { get; set; }
        public int DiaVencimentoBoleto { get; set; }
        public TipoCobranca TipoCobranca { get; set; }
        public bool BoletoEmail { get; set; }
    }
}
