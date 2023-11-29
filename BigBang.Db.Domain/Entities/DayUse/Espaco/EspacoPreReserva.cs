using Db.Domain.Entities.Cadastros.Base;
using Domain.Entities;
using System;

namespace Db.Domain.Entities.Cadastros.DayUse
{
    public class EspacoPreReserva : BaseEntityGenerico
    {
        public int EspacoId { get; set; }
        public Espaco Espaco { get; set; }
        public int UsuarioId { get; set; }
        public ApplicationUser Usuario { get; set; }
        public DateTime Data { get; set; }
    }
}
