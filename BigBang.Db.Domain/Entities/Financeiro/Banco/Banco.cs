using Api.Domain.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Db.Domain.Entities.Cadastros
{
    public class Bancos : BaseEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.None)]
        public override int Id { get; set; }
        public string Descricao { get; set; }
    }
}
