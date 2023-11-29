using Domain.Entities;

namespace Db.Domain.Entities.Base.PessoaJuridicaFisica
{
    public class AgendaTelefonica : BaseEntityGenerico
    {
        public string Nome { get; set; }
        public string Telefone01 { get; set; }
        public string Telefone02 { get; set; }
        public string Celular { get; set; }
        public string Obs { get; set; }
    }
}
