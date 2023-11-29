using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Db.Domain.Entities.Cadastros.Base;
using Db.Domain.Entities.Hotel.Quartos;
using Domain.Entities;

namespace Db.Domain.Entities.Hotel.Reservas
{
    public class Diaria : BaseEntityGenerico
    {
        public Reserva Reserva { get; set; }
        public int ReservaId { get; set; }
        public ApplicationUser Usuario { get; set; }
        public int UsuarioId { get; set; }
        public Quarto Quarto { get; set; }
        public int QuartoId { get; set; }
        public DateTime Data { get; set; }
        public decimal Valor { get; set; }
    }
}
