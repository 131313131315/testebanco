using Api.Domain.Entities;

namespace Domain.Entities.Cadastros.Produto
{
    public class ConfiguracaoIss : BaseEntity
    {
        public bool CalculaISS { get; set; }
        public bool RetencaoISS { get; set; }
        public decimal PercentualReducaoISS { get; set; }
        public string SituacaoTributariaISS { get; set; }
    }
}
