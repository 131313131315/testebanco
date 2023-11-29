using Api.Domain.Entities;
using Db.Domain.Enum.DayUse;
using Domain.Entities;
using Domain.Entities.Cadastros.PessoaJuridicaFisica;
using System;

namespace Db.Domain.Entities.Cadastros.DayUse
{
    public class EspacoEspera : BaseEntity
    {
        public TipoReserva TipoReserva { get; set; }
        public int PessoaId { get; set; }
        public Pessoa Pessoa { get; set; }
        public DateTime DataPretendida { get; set; }
    }
}
