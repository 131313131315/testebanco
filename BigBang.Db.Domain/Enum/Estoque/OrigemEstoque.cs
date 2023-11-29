using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Db.Domain.Enum.Estoque
{
    public enum OrigemEstoque
    {
        [Display(Name = "VP")]
        VendaProduto = 1,
        [Display(Name = "AE")]
        AcertoEstoque = 2,
        [Display(Name = "CP")]
        CadastroProduto = 3,
        [Display(Name = "NE")]
        NotaFiscal = 4,
        [Display(Name = "ES")]
        Estorno = 5,
    }
}
