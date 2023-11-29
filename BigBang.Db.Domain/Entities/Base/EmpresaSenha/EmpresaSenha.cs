using Api.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Db.Domain.Entities.Base.EmpresaSenha
{
    public class EmpresaSenha : BaseEntity
    {
        public int EmpresaId { get; set; }
        public int Senha { get; set; }
        public bool SenhaTodasVenda { get; set; }
        public DateTime UltimaVenda { get; set; }
    }
}
