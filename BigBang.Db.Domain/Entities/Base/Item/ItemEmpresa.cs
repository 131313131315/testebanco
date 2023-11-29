using Api.Domain.Entities;
using Domain.Entities.Cadastros.Empresa;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Cadastros.Produto
{
    public class ItemEmpresa : BaseEntity
    {
        [Column(Order = 1)]
        public int EmpresaId { get; set; }
        public Empresas Empresa { get; set; }
        [Column(Order = 2)]
        public int ItemId { get; set; }
        public produto Item { get; set; }
        public bool? ImprimeCozinha { get; set; }
        public string NomeImpressora { get; set; }
    }
}
