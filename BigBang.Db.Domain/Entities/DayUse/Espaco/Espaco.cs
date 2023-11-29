using Api.Domain.Entities;
using Db.Domain.Entities.Cadastros.Base;
using Db.Domain.Enum.DayUse;
using System.Collections.Generic;

namespace Db.Domain.Entities.Cadastros.DayUse
{
    public class Espaco : BaseEntity
    {
        public string Descricao { get; set; }
        public int TamanhoEspacoId { get; set; }
        public TamanhoEspaco TamanhoEspaco { get; set; }
        public int Numero { get; set; }
        public TipoEspaco TipoEspaco { get; set; }
        //public IEnumerable<MovimentacaoCaixa> MovimentacaoCaixa { get; set; }
    }
}
