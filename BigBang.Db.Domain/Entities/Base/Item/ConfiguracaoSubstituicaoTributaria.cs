using Api.Domain.Entities;

namespace Domain.Entities.Cadastros.Produto
{
    public class ConfiguracaoSubstituicaoTributaria : BaseEntity
    {
        public bool CalculaSubstituicaoTributaria { get; set; }
        public decimal PercentualReducaoSubstituicaoTributaria { get; set; }
        public bool AplicaIPIBaseCalculo { get; set; }
        public bool AplicaPisConfinsBaseCalculo { get; set; }
    }
}
