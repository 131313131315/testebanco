using Api.Domain.Entities;
using Domain.Entities;
using System;

namespace Db.Domain.Entities.Hotel.Pacotes
{
    public class PacoteMensal : BaseEntity
    {
        public DateTime MesVigente { get; set; }        
        public string Dias { get; set; }
        public decimal ValorDiaria { get; set; }
        public decimal ValorAdicional { get; set; }
        public decimal ValorGrupo { get; set; }
    }
}
