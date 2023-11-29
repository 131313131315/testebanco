using Domain.Entities;
using Domain.Entities.Cadastros.PessoaJuridicaFisica;

namespace Db.Domain.Entities.Base.PessoaJuridicaFisica
{
    public class AgenciasPessoas : BaseEntityGenerico
    {
        public int PessoaId { get; set; }
        public Pessoa Pessoa { get; set; }
        public int AgenciaId { get; set; }
        public Pessoa Agencia { get; set; }
    }
}
