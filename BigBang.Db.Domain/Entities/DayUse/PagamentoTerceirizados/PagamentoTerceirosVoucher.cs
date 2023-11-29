using Domain.Entities;
using Domain.Entities.Cadastros.Empresa;
using Domain.Entities.Cadastros.Produto;
using System;

namespace Db.Domain.Entities.DayUse.PagamentoTerceirizados
{
    public class PagamentoTerceirosVoucher : BaseEntityGenerico
    {
        public Excursao Excursao { get; set; }
        public int ExcursaoId { get; set; }
        public Empresas Empresa { get; set; }
        public int EmpresaId { get; set; }
        public int Voucher { get; set; }
        public produto Produto { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorTotal { get; set; }
        public PagamentoTerceiro PagamentoTerceiro { get; set; }
        public int? PagamentoTerceiroId { get; set; }
        public DateTime? DataConsumo { get; set; }
        public int Parcela { get; set; }
        public DateTime? DataParcela { get; set; }
        public DateTime? DataPagamento { get; set; }       
        public decimal ValorParcela { get; set; }
    }
}
