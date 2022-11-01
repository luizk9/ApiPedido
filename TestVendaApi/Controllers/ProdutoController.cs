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
    public class ProdutoController : ControllerBase
    {
        [HttpGet]
        public ActionResult<List<Produto>> Get()
        { 
            var produto = new Produto()
            {
                id = 1,
                Descricao = "Bola",
                Estoque = 2,
                Valor = 205
            };
            var produto2 = new Produto()
            {
                id = 2,
                Descricao = "campo",
                Estoque = 1,
                Valor = 555
            };
            var produtos = new List<Produto>();
            produtos.Add(produto);
            produtos.Add(produto2);

            return produtos;
        }

        [HttpGet("{Id}")]
        public ActionResult<Produto> Get(string id)
        {
            var produto = new Produto()
            {
                id = 3,
                Descricao = "mouse",
                Estoque = 1,
                Valor = 5
            };

             return produto;
        }

        [HttpPost]
        public ActionResult<ReturnResponse> Post( [FromBody] Produto request)
        {
            var retorno = new ReturnResponse()
            {
                Code = 200,
                Messege = " Resgistro cadastrado com"
            };            
            return retorno;
        }

         [HttpPut]
        public ActionResult<ReturnResponse> Put( [FromBody] Produto request)
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