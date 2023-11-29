using Api.Domain.Entities;

namespace Domain.Entities.Cadastros
{
    public class Departamento : BaseEntity
    {
        public string Descricao { get; set; }
        public bool UtilizaHotel { get; set; }
        public int Ordem { get; set; }
    }
}
