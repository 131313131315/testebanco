using Api.Domain.Entities;
using Domain.Entities.Cadastros.Empresa;
using System;
using System.Collections.Generic;
using System.Text;

namespace Db.Domain.Entities.Base.Mesa
{
    public class MesaBar : BaseEntity
    {
        public int? EmpresaId { get; set; }
        public Empresas Empresa { get; set; }
        public string NumeroMesa { get; set; }

    }
}
