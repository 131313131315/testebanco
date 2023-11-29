using Api.Domain.Entities;

namespace Domain.Entities.Cadastros.Produto
{
    public class ConfiguracaoPisConfins : BaseEntity
    {
        public bool CalculaPisConfins { get; set; }
        public string SituacaoTributariaPisConfins { get; set; }
        public bool RetencaoPis { get; set; }
        public bool RetencaoConfins { get; set; }
        public decimal PercentualReducaoConfins { get; set; }
        public decimal PercentualReducaoPis { get; set; }
        public bool AplicaIPIBaseCalculo { get; set; }
    }
}
