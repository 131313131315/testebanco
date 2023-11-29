using Api.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Db.Domain.Entities.DayUse.AutoAtendimento
{
    public class AutomacaoConfiguracao : BaseEntity
    {
        public string Descricao { get; set; }
        public bool UtilizaFora { get; set; }
    }
}
