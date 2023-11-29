using Db.Domain.Entities.Cadastros.Base;
using Db.Domain.Entities.DayUse.VendaBar;
using Domain.Entities;
using Domain.Entities.Cadastros.Produto;

namespace Db.Domain.Entities.Cadastros.DayUse.Cartao
{
    public class MovimentacaoCartaoProdutos : BaseEntityGenerico
    {
        public int MovimentacaoCartaoId { get; set; }
        public MovimentacaoCartaoConsumo MovimentacaoCartao { get; set; }
        public int ItemId { get; set; }
        public produto Item { get; set; }
        public int? VendaBarId { get; set; }
        public VendaBar VendaBar { get; set; }
        public decimal Quantidade { get; set; }
        public bool Cancelado { get; set; }
        public bool? VendaMobile { get; set; }
        public bool? Entregue { get; set; }
        public decimal Total { get; set; }
        public int? UsuarioId { get; set; }
        public ApplicationUser Usuario { get; set; }
        public int? UsuarioEstornoId { get; set; }
        public ApplicationUser UsuarioEstorno { get; set; }

    }
}
