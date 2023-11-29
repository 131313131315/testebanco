using Api.Domain.Entities;
using Db.Domain.Enum.DayUse;
using Domain.Entities;


namespace Db.Domain.Entities.DayUse.AutoAtendimento
{
    public class AutomacaoLocalizacao : BaseEntity
    {
        public string Descricao { get; set; }
        public int? ArmarioIni { get; set; }
        public int? ArmarioFim { get; set; }
        public string? QtdeVendaMaximoML { get; set; }
        public string IP { get; set; }
        public string IpServidor { get; set; }
        public string Bloco { get; set; }

        public TipoAutomacao TipoAutomacao { get; set; }
        public bool ComandoAbrirFechar { get; set; }
        public decimal? Valor { get; set; }
        public int? ItemId { get; set; }
        public int? EmpresaId { get; set; }
        public AutomacaoConfiguracao AutomacaoConfiguracao { get; set; }
        public int? AutomacaoConfiguracaoId { get; set; }
        public bool? Wifi { get; set; }


    }

}
