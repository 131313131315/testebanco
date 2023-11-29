using Api.Domain.Entities;
using Db.Domain.Entities.Base.Mesa;
using System;
using System.Collections.Generic;
using System.Text;

namespace Db.Domain.Entities.DayUse.VendaBar
{
    public class VendaBar : BaseEntity
    {        
        public int? MesaBarId { get; set; }
        public MesaBar MesaBar { get; set; }        
        public bool Ativo { get; set; }
        public string Observacao { get; set; }        
        public DateTime DataVenda { get; set; }

    }
}
