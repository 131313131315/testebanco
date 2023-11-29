using Api.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Db.Domain.Entities.Base.Estacionamento
{
    public class EstacionamentoBaixa : BaseEntity
    {
        public DateTime Data { get; set; }
        public string NumeroTicket { get; set; }
        public int NumeroTitulo { get; set; }
        public string Cota { get; set; }
        public string Carteirinha { get; set; }
    }
}
