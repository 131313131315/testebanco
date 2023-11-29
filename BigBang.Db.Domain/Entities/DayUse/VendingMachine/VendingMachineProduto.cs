using Api.Domain.Entities;
using Domain.Entities.Cadastros.Produto;

namespace Db.Domain.Entities.DayUse.VendingMachine
{
    public class VendingMachineProduto : BaseEntity
    {
        public string NumeroFileira { get; set; }
        public string IndiceImagem { get; set; }
        public string QtdeProdutoFileira { get; set; }
        public string QtdeProdutoFileriaReal { get; set; }
        public VendingMachine VendingMachine { get; set; }
        public int? VendingMachineId { get; set; }
        public produto Item { get; set; }
        public int? ItemId { get; set; }
    }
}
