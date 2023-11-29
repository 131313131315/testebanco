using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Db.Domain.Entities.Hotel.Refeicao
{
    public class RefeicaoReserva : BaseEntityGenerico
    {
        public string Descricao { get; set; }
        public DateTime HoraMaximaParaConsumo { get; set; }
    }
}
