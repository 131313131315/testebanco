using Api.Domain.Entities;
using Db.Domain.Enum.DayUse;
using Domain.Entities.Cadastros.EmpresaNFs;
using Domain.Entities.Cadastros.Produto;
using Domain.Enum;
using System;
using System.Collections.Generic;

namespace Domain.Entities.Cadastros.Empresa
{
    public class Empresas : BaseEntity
    {
        public string RazaoSocial { get; set; }
        public string Fantasia { get; set; }
        public string Email { get; set; }
        public string Observacao { get; set; }
        public bool Bloqueio { get; set; }
        public DateTime? DataInicio { get; set; }
        public IEnumerable<Endereco> Enderecos { get; set; }
        public IEnumerable<Telefone> Telefones { get; set; }
        public string Cnpj { get; set; }
        public string InscricaoEstadual { get; set; }
        public string InscricaoMunicipal { get; set; }
        public string Responsavel { get; set; }
        public TipoEmpresa? TipoEmpresa { get; set; }
        public byte[] Logo { get; set; }
        public TipoRegimeTributario? TipoRegimeTributario { get; set; }
        public TipoEstoque? TipoEstoque { get; set; }
        public bool NFCe { get; set; }
        public bool NFe { get; set; }
        public bool NFSe { get; set; }
        public decimal Porcentagem { get; set; }
        public EmpresaNF EmpresaNf { get; set; }
        public bool MostrarValorVendas { get; set; }
        public IEnumerable<ItemEmpresa> ItemEmpresa { get; set; }        
        public string TokenCpfCnpj { get; set; }
        public string IdPacoteCpf { get; set; }
        public int? ComissaoArmario { get; set; }
        public bool UtilizaBalanca { get; set; }
        public TipoImpressao TipoImpressao { get; set; }
        
    }
}
