using Db.Domain.Entities.Hotel.Pacotes;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Db.Domain.Entities.Hotel.Reservas
{
    public class ReservaPacote : BaseEntityGenerico
    {

        public Reserva Reserva { get; set; }
        public int ReservaId { get; set; }
        public PacoteMensal Pacote { get; set; }
        public int PacoteId { get; set; }
    }
}
