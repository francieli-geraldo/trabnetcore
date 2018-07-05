using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.UI.Models
{
    public class Produto_VendaVM : Produto_Venda
    {
        public decimal Total { get { return this.QuantidadeProduto * this.ValorUnitario; } }
    }
}
