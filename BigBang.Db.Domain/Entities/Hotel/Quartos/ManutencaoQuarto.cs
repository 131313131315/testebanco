using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Db.Domain.Entities.Hotel.Quartos
{
    public class ManutencaoQuarto : BaseEntityGenerico
    {
        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }
        public string IdQuarto { get; set; }
        public string Observacao { get; set; }
    }
}
