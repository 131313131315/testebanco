using Api.Domain.Entities;
using Db.Domain.Entities.Cadastros;
using Db.Domain.Enum.Hotel;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Db.Domain.Entities.Hotel.Quartos
{
    public class Categoria : BaseEntityGenerico
    {
        public string Descricao { get; set; }        
        public decimal Tarifa { get; set; }
        
    }
}
