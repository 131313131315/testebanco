using Api.Domain.Entities;
using Db.Domain.Entities.Cadastros.DayUse.PassaportePacote;
using Domain.Entities;
using System;

namespace Db.Domain.Entities.DayUse
{
    public class ExcursaoPassaporte : BaseEntity
    {
        public int ExcursaoId { get; set; }
        public Excursao Excursao { get; set; }
        public int? PacotePassaporteId { get; set; }
        public PassaportePacote PacotePassaporte { get; set; }
        public int Quantidade { get; set; }
        public decimal Valor { get; set; }
        public decimal Total { get; set; }
        public bool GerouVoucher { get; set; }
        public bool Baixado { get; set; }
        public DateTime? DataLancamento { get; set; }
    }
}
