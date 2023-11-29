using Db.Domain.Enum.Hotel;
using Domain.Entities;
using Domain.Entities.Cadastros.PessoaJuridicaFisica;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Db.Domain.Entities.Hotel.Hospede
{
    public class HospedeCredito : BaseEntityGenerico
    {
        public Pessoa Titular { get; set; }
        public int TitularId { get; set; }
 
        public int IdReservaOrigem { get; set; }

        public int? IdReservaDestino { get; set; }

        public OrigemCredito? OrigemCredito { get; set; }
    }
}
