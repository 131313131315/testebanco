using Domain.Entities;
using Domain.Entities.Cadastros.Empresa;

namespace Db.Domain.Entities.Cadastros.Base.Metas
{
    public class PontosMeta : BaseEntityGenerico
    {
        public string Ano { get; set; }
        public decimal ValorPonto { get; set; }
        public Empresas Empresa { get; set; }
        public int EmpresaId { get; set; }
    }
}
