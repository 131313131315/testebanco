using Domain.Entities;

namespace Db.Domain.Entities.Cadastros.DayUse.Estacionamento
{
    public class EstacionamentoSocio : BaseEntityGenerico
    {
        public string Titulo { get; set; }
        public string Cota { get; set; }
        public int QuantidadeLiberacao { get; set; }
    }
}