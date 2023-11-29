using Domain.Entities;
using Domain.Entities.Cadastros.Empresa;
using System;

namespace Db.Domain.Entities.DayUse.PagamentoTerceirizados
{
    public class PagamentoTerceiro : BaseEntityGenerico
    {
        public Empresas Empresa { get; set; }
        public int EmpresaId { get; set; }
        public decimal ValorTotal { get; set; }
        public decimal ValorBarTotal { get; set; }        
        public decimal ValorBarComDesconto { get; set; }
        public decimal ValorAdminBarComDesconto { get; set; }
        public decimal ValorAdministracao { get; set; }
        public decimal ValorTerceiroTotal { get; set; }
        public decimal ValorDescontoPagCartao { get; set; }
        public decimal ValorTotalPagCartao { get; set; }
        public DateTime DataPagamentoInicio { get; set; }
        public DateTime DataPagamentoFim { get; set; }
        public bool Situacao { get; set; }
        public decimal ValorTotalParceladoExcursao { get; set; }
        public decimal ValorTotalVistaExcursao { get; set; }
        public decimal ValorTerceirosVistaExcursao { get; set; }
        public decimal ValorAdministradorVistaExcursao { get; set; }
        public decimal ValorTerceirosParceladoExcursao { get; set; }
        public decimal ValorAdministradorParceladoExcursao { get; set; }
        public decimal valorTerceiros100Porcento { get; set; }
    }
}
