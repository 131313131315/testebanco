using Api.Domain.Entities;
using Db.Domain.Entities.Cadastros.Base;
using Db.Domain.Entities.Cadastros.DayUse;
using Db.Domain.Enum.DayUse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Db.Domain.Entities.DayUse.AutoAtendimento
{
    public class AutomacaoMovimento : BaseEntity
    {
        public int? ArmarioId { get; set; }
        public Armario Armario { get; set; }
        public decimal? Valor { get; set; }
        public DateTime DataAluguel { get; set; }
        public DateTime? DataAberto { get; set; }
        public DateTime? DataEstorno { get; set; }
        public DateTime? DataDevolucao { get; set; }
        public TipoAutomacao TipoMovimento { get; set; }
        public int? AutomacaoId { get; set; }
        public AutomacaoLocalizacao Automacao { get; set; }
        public int? ML { get; set; }
        public int? NumeroComprovante { get; set; }
        public int? UsuarioEstornoId { get; set; }
        public ApplicationUser UsuarioEstorno { get; set; }

    }
}
