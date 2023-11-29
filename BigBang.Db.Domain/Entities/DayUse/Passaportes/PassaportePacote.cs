using Db.Domain.Enum.DayUse;
using Domain.Entities;
using System;
using System.ComponentModel;

namespace Db.Domain.Entities.Cadastros.DayUse.PassaportePacote
{
    public class PassaportePacote : BaseEntityGenerico
    {
        [Description("Excursao = 1 - Passaporte = 2 - Chale = 3 - Quiosque = 4 - SalaoFesta = 5 - Hospedagem = 6")]
        public TipoReserva TipoReserva { get; set; }
        [Description("Adulto = 1 - Infantil = 2 - Criacao = 3 - Senior = 4")]
        public TipoPessoaPark TipoPessoa { get; set; }
        public string Dias { get; set; }
        [Description("Park = 1 - Externo = 2 - Site = 3")]
        public TipoVendaPark TipoVenda { get; set; }
        public string Descricao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public decimal ValorInterno { get; set; }
        public decimal ValorExterno { get; set; }
        public decimal ValorSite { get; set; }
        public decimal ValorPos { get; set; }
        public decimal ValorAlmoco { get; set; }
        //
        //
        //public decimal ValorAlmoco { get; set; }
    }
}
