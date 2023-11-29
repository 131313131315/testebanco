using Api.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Db.Domain.Entities.DayUse.AutoAtendimento
{
    public class AutomacaoLog : BaseEntity
    {
        public string descricao { get; set; }
        public string Erro { get; set; }
        public string Bloco { get; set; }
        public DateTime Data { get; set; }
    }
}
