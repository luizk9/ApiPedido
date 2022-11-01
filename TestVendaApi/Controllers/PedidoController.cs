using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TestVendaApi.Models;
using TestVendaApi.Response;

namespace TestVendaApi.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Pedido>> Get()
        {
            var Pedido = new Pedido()
            {
                Nr_Pedido = 1,
                Cliente = new Cliente(),
                DT_Pedido = DateTime.Now,
                Tipo = "V",
                Item = new List<PedidoItem>()
            };
            var Pedido2 = new Pedido()
            {
                Nr_Pedido = 2,
                Cliente = new Cliente(),
                DT_Pedido = DateTime.Now,
                Tipo = "V",
                Item = new List<PedidoItem>()
            };

            var Pedidos = new List<Pedido>();
            Pedidos.Add(Pedido);
            Pedidos.Add(Pedido2);

            return Pedidos;

        }

        [HttpGet("{nr_pedido}")]
        public ActionResult<Pedido> Get(string nr_pedido)
        {
            var pedido = new Pedido()
            {
                Nr_Pedido = 2,
                Cliente = new Cliente(),
                DT_Pedido = DateTime.Now,
                Tipo = "V",
                Item = new List<PedidoItem>()    
            };
            return pedido;
        }

        [HttpPost]
        public ActionResult<ReturnResponse> Post( [FromBody] Pedido request)
        {
            var retorno = new ReturnResponse()
            {
                Code = 200,
                Messege = " Resgistro cadastrado com"
            };
            
            return retorno;
        }

         [HttpPut]
        public ActionResult<ReturnResponse> Put( [FromBody] Pedido request)
        {
            var retorno = new ReturnResponse()
            {
                Code = 200,
                Messege = " Resgistro cadastrado com"
            };
            
            return retorno;
        }

        [HttpDelete("{id}")]
        public ActionResult<ReturnResponse> Delete( string id)
        {
            var retorno = new ReturnResponse()
            {
                Code = 200,
                Messege = " Resgistro cadastrado com"
            };
            
            return retorno;
        }
    }
}