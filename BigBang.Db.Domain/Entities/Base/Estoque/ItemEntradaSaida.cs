using Api.Domain.Entities;
using Db.Domain.Enum.Estoque;
using Domain.Entities.Cadastros.Empresa;
using System;

namespace Domain.Entities.Cadastros.Produto
{
    public class ItemEntradaSaida : BaseEntity
    {
        public int ItemId { get; set; }         
        public produto Item { get; set; }
        public int EmpresaId { get; set; }
        public Empresas Empresa { get; set; }
        public int QtdeEntrada { get; set; }
        public int QtdeSaida { get; set; }
        public decimal? ValorCustoUnitario { get; set; }
        public DateTime? DataEntrada { get; set; }
        public DateTime? DataSaida { get; set; }
        public DateTime? DataLancamento { get; set; }
        public OrigemEstoque Origem { get; set; }
        public int? IdUsuarioInclusao { get; set; }
        public int? IdUsuarioEstorno { get; set; }
        public bool Estorno { get; set; }
    }
}
