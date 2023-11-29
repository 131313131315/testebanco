
using Db.Domain.Enum.DayUse;
using Domain.Entities;
using System;

namespace Db.Domain.Entities.DayUse.Log
{
    public class LogDayUser : BaseEntityGenerico
    {
        public TipoMovimentoLog TipoMovimentoLog { get; set; }
        public int? EmpresaId { get; set; }
        public decimal? Valor { get; set; }
        public string Mensagem { get; set; }
        public DateTime Data { get; set; }

    }
}
