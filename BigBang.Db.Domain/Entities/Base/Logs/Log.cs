using Api.Domain.Entities;
using Db.Domain.Entities.Cadastros.Base;
using Domain.Entities.Cadastros.PessoaJuridicaFisica;
using System;

namespace Db.Domain.Entities.Base.Logs
{
    public class Log : BaseEntity
    {
        public Pessoa Pessoa { get; set; }
        public int? PessoaId { get; set; }
        public DateTime DataOcorrencia { get; set; }
        public string Descricao { get; set; }
        public ApplicationUser Usuario { get; set; }
        public int? UsuarioId { get; set; }
        public string Modulo { get; set; }
    }
}
