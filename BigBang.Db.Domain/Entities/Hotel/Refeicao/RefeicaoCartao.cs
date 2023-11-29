using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Db.Domain.Entities.Hotel.Refeicao
{
    public class RefeicaoCartao : BaseEntityGenerico
    {
        public string numeroCartao { get; set; }
        public string situacao { get; set; }
    }
}
