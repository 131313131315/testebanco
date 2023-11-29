using Db.Domain.Entities.Cadastros.Base;
using Db.Domain.Enum.Hotel;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Db.Domain.Entities.Hotel.Reservas
{
    public class ReservaLog : BaseEntityGenerico
    {
        public ApplicationUser Usuario { get; set; }
        public int UsuarioId { get; set; }
        public Reserva Reserva { get; set; }
        public int? ReservaId { get; set; }
        public string Acao { get; set; }
        public DateTime DataHora { get; set; } = DateTime.Now;
        public string UsuarioGerente { get; set; }
        public TipoAcao TipoAcao { get; set; }
    }
}
