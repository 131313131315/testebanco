using Api.Domain.Entities;
using Db.Domain.Entities.Cadastros.Base;
using Domain.Entities.Cadastros.Produto;
using System;
using System.Collections.Generic;
using System.Text;

namespace Db.Domain.Entities.DayUse.PagamentoTerceirizados
{
    public class PagamentoTerceirosItem : BaseEntity
    {
        public produto Produto { get; set; }
        public int ProdutoId { get; set; }
        public ApplicationUser Usuario { get; set; }
        public int? UsuarioId { get; set; }
        public PagamentoTerceiro PagamentoTerceiro { get; set; }
        public int PagamentoTerceiroId { get; set; }
        public decimal Quantidade { get; set; }
        public decimal ValorTotal { get; set; }
        public bool Estorno { get; set; }
        public int EmpresaId { get; set; }
    }
}
