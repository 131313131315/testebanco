using Api.Domain.Entities;
using Domain.Entities.Cadastros.PessoaJuridicaFisica;
using Domain.Enum;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Cadastros.Empresa
{
    public class Telefone : BaseEntity
    {
        [Column(Order = 1)]
        public int? EmpresaId { get; set; }
        public Empresas Empresa { get; set; }
        [Column(Order = 2)]
        public int? PessoaId { get; set; }
        public Pessoa Pessoa { get; set; }
        public string DDD { get; set; }
        public string Numero { get; set; }
        public TipoTelefone TipoTelefone { get; set; }
        public OperadoraTelefonia Operadora { get; set; }
    }
}
