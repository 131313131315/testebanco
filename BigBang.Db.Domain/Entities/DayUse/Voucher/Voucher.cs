using Api.Domain.Entities;
using Db.Domain.Entities.Cadastros.Base;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Db.Domain.Entities.DayUse.Voucher
{
    public class VoucherPassaporte : BaseEntity
    {
        public string Voucher { get; set; }
        public string Responsavel { get; set; }
        public string Telefone { get; set; }
        public DateTime DataHora { get; set; }
        public DateTime? DataBaixado { get; set; }
        public int? QuantidadeAdulto { get; set; }
        public int? QuantidadeCrianca { get; set; }
        public int? QuantidadeNaoEspecificada { get; set; }
        public int? UsuarioId { get; set; }
        public ApplicationUser Usuario { get; set; }
        public int? Entrada { get; set; }
        public bool? Baixado { get; set; }

    }
}
