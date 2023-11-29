using Api.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Db.Domain.Entities.Hotel.Pacotes
{
    public class Pacote : BaseEntity
    {
        public string Descricao { get; set; }
        public DateTime DataInicial { get; set; }
        public DateTime DataFinal { get; set; }
        public int EstadiaMinima { get; set; }
        public int QuantidadeDeAdultos { get; set; }
        public int QuantidadeDeCriancas { get; set; }
        public decimal DescontoMaximo { get; set; }
        public decimal ValorPacote { get; set; }
        public decimal ValorAdicional { get; set; }
        public decimal ValorGrupos { get; set; }
        public string Observacao { get; set; }
    }
}
