using APICatalogo.Context;
using APICatalogo.Models;
using APICatalogo.Repository;
using APICatalogo.Validations;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace APICatalogo.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly IUnitOfWork _uof;
    


        public ProdutosController(IUnitOfWork uof)
        {
           
            _uof=uof;
        }

        [HttpGet("produtos{id}")]

        public ActionResult<IEnumerable<Produto>> GetProdutosCategoria(int id)
        {
            var produtos = _uof.ProdutoRepository.GetProdutosPorCategoria(id);
            if (produtos is null)
            {
                return NotFound();
            }
            return Ok
                (produtos);
        }

        [HttpGet]
        public ActionResult<IEnumerable<Produto>> Get()
        {
            var produtos =_uof.ProdutoRepository.GetAll();

            if (produtos is null)
            {
                return NotFound();
            }
            return Ok(produtos);
            
        }

        [HttpGet("{id}", Name = "ObterProduto")]
        public ActionResult<Produto> Get(int id)
        {
            var produto =  _uof.ProdutoRepository.Get(c=>c.ProdutoId==id);
            if (produto is null)
            {
                return NotFound("Produto não encontrado...");
            }
            return produto;
        }

        [HttpPost]
        public ActionResult Post(Produto produto)
        {
            if (produto is null)
                return BadRequest();

           var novoProduto = _uof.ProdutoRepository.Create(produto);
            _uof.Commit();
            return new CreatedAtRouteResult("ObterProduto",
                new { id = novoProduto.ProdutoId }, novoProduto);
        }

        [HttpPut("{id:int}")]
        public ActionResult Put(int id, Produto produto)
        {
            if (id != produto.ProdutoId)
            {
                return BadRequest();
            }
           var produtoAtualizado= _uof.ProdutoRepository.Update(produto);
            _uof.Commit();
            return Ok(produtoAtualizado);
                       
        }

        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id)
        {
            var produto = _uof.ProdutoRepository.Get(c=> c.ProdutoId == id);

            if (produto is null)
            {
                return NotFound("Produto não encontrado...");
            }
            var produtoExcluido =_uof.ProdutoRepository.Delete(produto);
            _uof.Commit();
            return Ok(produtoExcluido);
        }
    }
}
