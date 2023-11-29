using Api.Domain.Entities;
using Db.Domain.Entities.Cadastros;
using Domain.Entities.Cadastros.Empresa;
using System;

namespace Db.Domain.Entities.Financeiro.Cheques
{
    public class ControleCheque : BaseEntity
    {
        public Empresas Empresa { get; set; }
        public int EmpresaId { get; set; }
        public decimal ValorCheque { get; set; }
        public string NumeroCheque { get; set; }
        public Bancos Banco { get; set; }
        public int BancoId { get; set; }
        public string NomeEmitente { get; set; }
        public string Referente { get; set; }
        public string Destinatario { get; set; }
        public DateTime? DataPagamento { get; set; }
        public bool Pago { get; set; }
        public bool Devolvido { get; set; }
    }
}
