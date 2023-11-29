using Api.Domain.Entities;
using Domain.Entities;
using Domain.Entities.Cadastros.Produto;
using System;

namespace Db.Domain.Entities.DayUse
{
    public class ExcursaoProdutos : BaseEntity
    {
        public int ExcursaoId { get; set; }
        public Excursao Excursao { get; set; }
        public int ProdutoId { get; set; }
        public produto Produto { get; set; }
        public int Quantidade { get; set; }
        public decimal Valor { get; set; }
        public decimal Total { get; set; }
        public int? Voucher { get; set; }
        public bool GerouVoucher { get; set; }
        public bool Baixado { get; set; }        
        public DateTime? DataBaixa { get; set; }
        public DateTime? DataLancamento { get; set; }

    }
}
