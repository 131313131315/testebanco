using Api.Domain.Entities;
using Db.Domain.Enum.Hotel;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Db.Domain.Entities.Hotel.Quartos
{
    public class Quarto : BaseEntityGenerico
    {
        public int NumeroQuarto { get; set; }
        public Categoria Categoria { get; set; }
        public int CategoriaId { get; set; }
        public int QuantidadeDeHospedes { get; set; }
        public StatusQuartos Status { get; set; }
        public bool? Adaptado { get; set; }
    }
}
