using Api.Domain.Entities;
using System;

namespace Db.Domain.Entities.DayUse.Passaportes
{
    public class PassaporteLog : BaseEntity
    {
        public DateTime DataHoraLog { get; set; }
        public int IdPassaporte { get; set; }
    }
}
