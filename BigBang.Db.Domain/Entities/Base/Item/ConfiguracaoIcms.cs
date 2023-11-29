using Api.Domain.Entities;

namespace Domain.Entities.Cadastros.Produto
{
    public class ConfiguracaoIcms : BaseEntity
    {
        public bool CalculaICMS { get; set; }
        public decimal PercentualTributacaoICMS { get; set; }
        public bool CalculaICMSDifal { get; set; }
        public bool AplicaValorIPIBaseCalculo { get; set; }
        public string CSOSNCT { get; set; }
        public bool ICMSDeferido { get; set; }
        public decimal PercentualICMSDeferido { get; set; }
        public decimal PercentualReducaoBase { get; set; }
    }
}
