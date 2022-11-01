using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace TestVendaApi.Models
{
    public class Pedido
    {
        
        public int Nr_Pedido { get; set; }
         public DateTime DT_Pedido { get; set; }
        public string Tipo { get; set; }
        public Cliente Cliente { get; set; }
        public List<PedidoItem> Item { get; set; }
    }
}