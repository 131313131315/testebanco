using Db.Domain.Entities.Hotel.Quartos;
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
    public class WaitList : BaseEntityGenerico
    {


        public virtual Categoria Categoria { get; set; }
        public int CategoriaId { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataSaida { get; set; }
        public int QuantidadeDeHospedes { get; set; }

        public virtual SituacaoDaReservaEmEspera Situacao { get; set; }
        public string Observacao { get; set; }
    }
}
