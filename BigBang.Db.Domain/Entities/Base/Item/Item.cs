using Api.Domain.Entities;
using Db.Domain.Entities.Base.Item;
using Domain.Enum;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Cadastros.Produto
{
    public class produto : BaseEntity
    {
        [Column(Order = 1)]
        public int? UnidadeId { get; set; }
        public UnidadeMedida Unidade { get; set; }
        [Column(Order = 2)]
        public int? DepartamentoId { get; set; }
        public Departamento Departamento { get; set; }
        public string Descricao { get; set; }
        public string DescricaoPainel { get; set; }
        public TipoItem TipoItem { get; set; }
        public string GTIN { get; set; }
        public string CodigoBarras { get; set; }
        public decimal ValorUnitario { get; set; }
        public string NCM { get; set; }
        public decimal Iss { get; set; }
        public string Cest { get; set; }
        //public decimal? EstoqueMinimo { get; set; }
        //public decimal? EstoqueMaximo { get; set; }
        public string CFOP { get; set; }
        public string CST { get; set; }
        public bool UtilizaHotel { get; set; }
        public decimal TributacaoFederal { get; set; }
        public decimal TributacaoEstadual { get; set; }
        public string SituacaoTributaria { get; set; }
        public byte[] Imagem { get; set; }
        public bool ComissaoTotal { get; set; }
        public string Cor { get; set; }
        //public bool ControlarEstoque { get; set; }
        //public bool ImprimeCozinha { get; set; }
        //public string NomeImpressora { get; set; }
    }
}
