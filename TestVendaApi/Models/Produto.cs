using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestVendaApi.Models
{
    public class Produto
    {
        public int id { get; set; }

        public string Descricao { get; set; }
        public int Estoque { get; set; }
         public  decimal Valor { get; set; }
    }
}