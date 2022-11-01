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
    public class ClienteController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Cliente>> Get()
        {
            var cliente = new Cliente()
            {
                Id = 1,
                Nome = "Bola",
                Email = "@gmail",
                DT_Nascimento = DateTime.Now.AddYears(-20)
            };
            var cliente2 = new Cliente()
            {
                Id = 2,
                Nome = "tatu",
                Email = "@gmail",
                DT_Nascimento = DateTime.Now.AddYears(-30)
            };
            var clientes = new List<Cliente>();
            clientes.Add(cliente);
            clientes.Add(cliente2);

            return clientes;
        }

        [HttpGet("{Id}")]
        public ActionResult<Cliente> Get(string id)
        {
            var cliente = new Cliente()
            {
                Id = 3,
                Nome = "Sonic",
                Email = "@sss",
                DT_Nascimento = DateTime.Now.AddYears(-25)
            };
            return cliente;
        }

        [HttpPost]
        public ActionResult<ReturnResponse> Post( [FromBody] Cliente request)
        {
            var retorno = new ReturnResponse()
            {
                Code = 200,
                Messege = " Resgistro cadastrado com"
            };            
            return retorno;
        }

         [HttpPut]
        public ActionResult<ReturnResponse> Put( [FromBody] Cliente request)
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