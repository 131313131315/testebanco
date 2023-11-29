using Api.Domain.Entities;
using Domain.Entities;
using Domain.Entities.Cadastros.Modulos;
using Domain.Entities.Cadastros.PapelUsuario;
using Domain.Entities.Cadastros.PessoaJuridicaFisica;
using Domain.Entities.Cadastros.Produto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Db.Domain.Entities.Base.Quadra
{
    public class MovimentoQuadra : BaseEntityGenerico
    {

        public int? Pessoa1Id { get; set; }
        public Pessoa Pessoa1 { get; set; }

        public int? Pessoa2Id { get; set; }
        public Pessoa Pessoa2 { get; set; }

        public int? Pessoa3Id { get; set; }
        public Pessoa Pessoa3 { get; set; }

        public int? Pessoa4Id { get; set; }
        public Pessoa Pessoa4 { get; set; }

        public bool? Pagamento1 { get; set; }        

        public bool? Pagamento2 { get; set; }        

        public bool? Pagamento3 { get; set; }        

        public bool? Pagamento4 { get; set; }        


        public int? HorarioId { get; set; }
        public HorarioQuadra Horario { get; set; }
        public DateTime Data { get; set;}

    }
}
