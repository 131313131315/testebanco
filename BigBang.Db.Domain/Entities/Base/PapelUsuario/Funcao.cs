using Domain.Entities.Cadastros.Modulos;
using Domain.Entities.Cadastros.PapelUsuario;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Funcao : BaseEntityGenerico
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int ModulosId { get; set; }
        public Modulos Modulos { get; set; }
        public ICollection<FuncaoAcoes> FuncaoAcoes { get; set; }
        public ICollection<FuncaoAcaoPerfil> AcoesPerfil { get; set; }
    }
}
