using Api.Domain.Entities;
using Domain.Entities;
using System;

namespace Db.Domain.Entities.Cadastros.DayUse
{
    public class PassaportePromocao : BaseEntity
    {
        public string Descricao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public decimal PorcentagemDesconto { get; set; }
        public decimal ValorDesconto { get; set; }
    }
}
