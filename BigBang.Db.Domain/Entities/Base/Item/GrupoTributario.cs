using Api.Domain.Entities;

namespace Domain.Entities.Cadastros.Produto
{
    public class GrupoTributario : BaseEntity
    {
        public string Descricao { get; set; }
        public string CFOP { get; set; }
        public bool GeraFinanceiro { get; set; }
        public int ConfiguracaoICMSId { get; set; }
        public ConfiguracaoIcms ConfiguracaoICMS { get; set; }
        public int ConfiguracaoIPIId { get; set; }
        public ConfiguracaoIpi ConfiguracaoIPI { get; set; }
        public int ConfiguracaoPisConfinsId { get; set; }
        public ConfiguracaoPisConfins ConfiguracaoPisConfins { get; set; }
        public int ConfiguracaoISSId { get; set; }
        public ConfiguracaoIss ConfiguracaoISS { get; set; }
        public int ConfiguracaoSubstituicaoTributariaId { get; set; }
        public ConfiguracaoSubstituicaoTributaria ConfiguracaoSubstituicaoTributaria { get; set; }
    }
}
