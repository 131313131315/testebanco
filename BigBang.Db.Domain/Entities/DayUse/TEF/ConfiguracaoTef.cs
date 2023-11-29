using Db.Domain.Entities.Cadastros.DayUse.Cartao;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Db.Domain.Entities.DayUse.TEF
{
    public class ConfiguracaoTef : BaseEntityGenerico
    {
        public string Cnpj { get; set; }
        public int PessoaId { get; set; }
        public string ChaveAcesso { get; set; }
        public string Adquirente { get; set; }
        public bool AguardarTefIniciarTransacao { get; set; }
        public bool ParcelamentoAdmin { get; set; }
        public virtual IEnumerable<TerminaisTef> Terminais { get; set; }
    }
    public class TerminaisTef : BaseEntityGenerico
    {
        public int TerminalId { get; set; }
        public string NomeComputador { get; set; }
        public virtual ConfiguracaoTef ConfiguracaoTef { get; set; }
        public int ConfiguracaoTefId { get; set; }
        public string Descricao { get; set; }
        public IEnumerable<MovimentacaoCartaoConsumo> MovimentacaoCartoes { get; set; }
    }
}
