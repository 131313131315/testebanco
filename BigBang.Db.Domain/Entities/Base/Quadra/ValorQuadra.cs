﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Db.Domain.Entities.Base.Quadra
{


    public class ValorQuadra : BaseEntityGenerico
    {
        public string Descricao { get; set; }
        public decimal Valor { get; set; }        
    }
}
