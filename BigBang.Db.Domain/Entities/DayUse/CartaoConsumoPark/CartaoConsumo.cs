using Db.Domain.Enum.DayUse;
using Domain.Entities;
using Domain.Entities.Cadastros.Empresa;
using System;

namespace Db.Domain.Entities.Cadastros.DayUse.Cartao
{
    public class CartaoConsumo : BaseEntityGenerico
    {
        public string Numero { get; set; }
        public string Numero2 { get; set; }
        public string NomeAluno { get; set; }
        public string TelefoneAluno { get; set; }
        public string SerieAluno { get; set; }
        public SituacaoCartao Situacao { get; set; }
        public TipoCartaoConsumo TipoCartaoConsumo { get; set; }
        public int? NumeroComprovante { get; set; }
        public Armario Armarios { get; set; }
        public int? EmpresaCartaoRetidoId{ get; set; }
        public Empresas EmpresaCartaoRetido { get; set; }
        public DateTime? DataCartaoRetido { get; set; }

    }
}
