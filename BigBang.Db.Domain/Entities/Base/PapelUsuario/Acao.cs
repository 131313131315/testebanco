using System.Collections.Generic;

namespace Domain.Entities.Cadastros.PapelUsuario
{
    public class Acao : BaseEntityGenerico
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public ICollection<FuncaoAcaoPerfil> AcoesPerfil { get; set; }
        public ICollection<FuncaoAcoes> FuncaoAcoes { get; set; }
    }
}
