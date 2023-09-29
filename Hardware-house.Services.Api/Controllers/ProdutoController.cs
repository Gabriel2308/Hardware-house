using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Hardware_house.Infra.Entities;
using Hardware_house.Domain.Services;

namespace Hardware_house.Services.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        // GET: api/Produtoes
        [HttpGet]
        public ActionResult<IEnumerable<Produto>> GetProdutos()
        {
            ProdutoDomain domain = new();
            var produtos = domain.GetProdutos();
            if (produtos == null)
            {
                return NotFound("Nenhum produto encontrado.");
            }
            return Ok(produtos);
        }

        //// GET: api/Produtoes/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Produto>> GetProduto(int id)
        //{
        //    if (_context.Produtos == null)
        //    {
        //        return NotFound();
        //    }
        //    var produto = await _context.Produtos.FindAsync(id);

        //    if (produto == null)
        //    {
        //        return NotFound();
        //    }

        //    return produto;
        //}

        //// PUT: api/Produtoes/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutProduto(int id, Produto produto)
        //{
        //    if (id != produto.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(produto).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!ProdutoExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/Produtoes
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<Produto>> PostProduto(Produto produto)
        //{
        //    if (_context.Produtos == null)
        //    {
        //        return Problem("Entity set 'postgresContext.Produtos'  is null.");
        //    }
        //    _context.Produtos.Add(produto);
        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateException)
        //    {
        //        if (ProdutoExists(produto.Id))
        //        {
        //            return Conflict();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return CreatedAtAction("GetProduto", new { id = produto.Id }, produto);
        //}

        //// DELETE: api/Produtoes/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteProduto(int id)
        //{
        //    if (_context.Produtos == null)
        //    {
        //        return NotFound();
        //    }
        //    var produto = await _context.Produtos.FindAsync(id);
        //    if (produto == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.Produtos.Remove(produto);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //private bool ProdutoExists(int id)
        //{
        //    return (_context.Produtos?.Any(e => e.Id == id)).GetValueOrDefault();
        //}
    }
}
