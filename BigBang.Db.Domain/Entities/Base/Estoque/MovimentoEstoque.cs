using Api.Domain.Entities;
using Domain.Entities;
using Domain.Entities.Cadastros.Empresa;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Cadastros.Produto
{
    public class MovimentoEstoque : BaseEntityGenerico
    {
        public int ItemId { get; set; }
        public produto Item { get; set; }
        public int EmpresaId { get; set; }
        public Empresas Empresa { get; set; }
        public int QtdeEstoque { get; set; }
    }
}
