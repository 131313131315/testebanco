using Db.Domain.Entities.Cadastros.Base;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Db.Domain.Entities.Hotel.Refeicao
{

    public class RefeicaoUsuarioMovimento : BaseEntityGenerico
    {
        public string diaRefeicao { get; set; }
        public DateTime data { get; set; }
        public string hora { get; set; }
        public ApplicationUser Usuario { get; set; }
        public int UsuarioId { get; set; }
        public RefeicaoCartao Cartao { get; set; }
        public int CartaoId { get; set; }
        public RefeicaoReserva Refeicao { get; set; }        
        public int RefeicaoId { get; set; }
       

    }
}
