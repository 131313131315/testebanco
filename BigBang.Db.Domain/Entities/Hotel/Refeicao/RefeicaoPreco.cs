using Db.Domain.Enum.Hotel;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Db.Domain.Entities.Hotel.Refeicao
{
    public class RefeicaoPreco : BaseEntityGenerico
    {
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public RefeicaoReserva Refeicao { get; set; }
        public int RefeicaoId { get; set; }
        public TipoDeConsumidor TipoDeConsumidor { get; set; }
        public DateTime InicioDaVigencia { get; set; }
        public DateTime? FimDaVigencia { get; set; }
    }
}
