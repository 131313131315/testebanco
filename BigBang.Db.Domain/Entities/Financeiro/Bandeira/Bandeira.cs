using Api.Domain.Entities;

namespace Db.Domain.Entities.Financeiro.Bandeira
{
    public class Bandeira : BaseEntity
    {
        public string Descricao { get; set; }
        public byte[] Imagem { get; set; }
    }
}
