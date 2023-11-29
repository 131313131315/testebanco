using Api.Domain.Entities;
using Db.Domain.Entities.Base.PessoaJuridicaFisica;
using Db.Domain.Entities.Cadastros.Base;
using Db.Domain.Entities.Cadastros.Socio.CategoriaSocio;
using Db.Domain.Entities.Socio.SocioCobranca;
using Db.Domain.Entities.Socio.Titulos;
using Db.Domain.Enum.Base;
using Db.Domain.Enum.DayUse.Socio;
using Db.Domain.Enum.Hotel;
using Domain.Entities.Cadastros.Empresa;
using Domain.Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities.Cadastros.PessoaJuridicaFisica
{
    public class Pessoa : BaseEntity
    {
        //Pessoa Fisica
        public string Nome { get; set; }
        public DateTime? DataNascimento { get; set; }
        public string OrgaoExpedidor { get; set; }
        public string Estado { get; set; }
        public string Passaporte { get; set; }
        public string Nacionalidade { get; set; }

        public TipoSexo? Sexo { get; set; }
        public string NomeMae { get; set; }
        public string Profissao { get; set; }
        public string Certidao { get; set; }

        //Pessoa Juridica
        public string Razao { get; set; }
        public string NomeFantasia { get; set; }
        public string InscricaoMunicipal { get; set; }
        public string Responsavel { get; set; }

        // Em comum
        public string CpfCnpj { get; set; }
        public string RgInscEstadual { get; set; }
        public string Email { get; set; }
        public string Observacao { get; set; }
        public IEnumerable<Endereco> Endereco { get; set; }
        public IEnumerable<Telefone> Telefone { get; set; }
        public TipoPessoa TipoPessoa { get; set; }
        public TipoContaPessoa TipoContaPessoa { get; set; }
        public string RegNacExtrangeiro { get; set; }

        private DateTime? _dataCriacao;
        public DateTime? DataCriacao
        {
            get { return _dataCriacao; }
            set { _dataCriacao = (value == null ? DateTime.Now : value); }
        }
        public bool? Bloqueio { get; set; }

        //Socio
        public Pessoa Titular { get; set; }
        public int? TitularId { get; set; }
        public TipoParentesco? Parentesco { get; set; }
        public TipoSocio? TipoSocio { get; set; }
        public bool SocioAtivo { get; set; }
        public int? CategoriaSocioId { get; set; }
        public CategoriaSocio CategoriaSocio { get; set; }
        public TituloSocios TituloSocio { get; set; }
        public int? TituloSocioId { get; set; }
        public bool Agencia { get; set; }
        public List<AgenciasPessoas> Agencias { get; set; }
        public virtual SocioCobranca SocioCobranca { get; set; }
        public int? ID_TIPO_PESSOA { get; set; }//REMOVER

        //Hotel
        
        public TipoDeDocumento? TipoDocumentoDaHospedagem { get; set; }

        public SimNao? TitulardaReserva { get; set; }



        public int? UsuarioId { get; set; }
        public ApplicationUser Usuario { get; set; }

    }
}
