using Api.Domain.Entities;
using System;

namespace Db.Domain.Entities.Cadastros.DayUse
{
    public class Feriado : BaseEntity
    {
        public DateTime Data { get; set; }
        public string Descricao { get; set; }
    }
}
