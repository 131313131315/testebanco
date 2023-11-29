using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Db.Domain.Entities.Hotel.Quartos
{

    public class QuartoStandby : BaseEntityGenerico
    {

        public int IdQuarto { get; set; }
        public int IdUsuario { get; set; }
        public DateTime DataEntradaDaReserva { get; set; }
        public DateTime DataSaidaDaReserva { get; set; }
        public DateTime? DataHoraCadastro { get; set; }
    }
}
