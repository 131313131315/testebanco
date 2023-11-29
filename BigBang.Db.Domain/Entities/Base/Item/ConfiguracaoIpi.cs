using Api.Domain.Entities;

namespace Domain.Entities.Cadastros.Produto
{
    public class ConfiguracaoIpi : BaseEntity
    {
        public bool CalculaIPI { get; set; }
        public string SituacaoTributariaIPI { get; set; }
        public decimal PercentualReducaoIPI { get; set; }
    }
}
