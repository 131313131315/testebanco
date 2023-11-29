using Api.Domain.Entities;

namespace Db.Domain.Entities.Socio.Titulos
{
    public class SerieTitulo : BaseEntity
    {
        public string Descricao { get; set; }
        public int QuantidadeTitulos { get; set; }
    }
}
