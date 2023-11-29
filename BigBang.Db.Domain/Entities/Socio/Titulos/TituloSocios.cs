using Api.Domain.Entities;
using Domain.Entities.Cadastros.PessoaJuridicaFisica;
using System.Collections.Generic;

namespace Db.Domain.Entities.Socio.Titulos
{
    public class TituloSocios : BaseEntity
    {
        public virtual List<Pessoa> Socio { get; set; }
        public SerieTitulo SerieTitulo { get; set; }
        public int SerieTituloId { get; set; }
        public int Numero { get; set; }
        public bool Disponivel { get; set; }
    }
}
