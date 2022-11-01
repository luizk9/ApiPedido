using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestVendaApi.Models
{
    public class PedidoItem
    {
        public int id { get; set; }
        public int Quantidade { get; set; }
        public decimal valor_unit { get; set; }
        public Produto produto { get; set; }
    }
}