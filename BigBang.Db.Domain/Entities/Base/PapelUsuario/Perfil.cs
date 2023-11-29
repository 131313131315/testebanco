using Api.Domain.Entities;
using System.Collections.Generic;

namespace Domain.Entities.Cadastros.PapelUsuario
{
    public class Perfil : BaseEntity
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string TempoExpiracao { get; set; }
        public ICollection<FuncaoAcaoPerfil> AcoesPerfil { get; set; }
    }
}
