using Api.Domain.Entities;
using Domain.Entities.Cadastros.PessoaJuridicaFisica;
using Domain.Enum;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Cadastros.Empresa
{
    public class Endereco : BaseEntity
    {
        [Column(Order = 1)]
        public int? EmpresaId { get; set; }
        public Empresas Empresa { get; set; }
        [Column(Order = 2)]
        public int? PessoaId { get; set; }
        public Pessoa Pessoa { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Complemento { get; set; }
        public string Cep { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
        public TipoEndereco TipoEndereco { get; set; }
    }
}
