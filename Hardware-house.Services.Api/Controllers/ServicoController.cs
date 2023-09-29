using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Hardware_house.Infra.Entities;

namespace Hardware_house.Services.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServicoController : ControllerBase
    {
        private readonly postgresContext _context;

        public ServicoController(postgresContext context)
        {
            _context = context;
        }

        // GET: api/Servico
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Servico>>> GetServicos()
        {
          if (_context.Servicos == null)
          {
              return NotFound();
          }
            return await _context.Servicos.ToListAsync();
        }

        // GET: api/Servico/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Servico>> GetServico(int id)
        {
          if (_context.Servicos == null)
          {
              return NotFound();
          }
            var servico = await _context.Servicos.FindAsync(id);

            if (servico == null)
            {
                return NotFound();
            }

            return servico;
        }

        // PUT: api/Servico/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutServico(int id, Servico servico)
        {
            if (id != servico.Id)
            {
                return BadRequest();
            }

            _context.Entry(servico).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ServicoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Servico
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Servico>> PostServico(Servico servico)
        {
          if (_context.Servicos == null)
          {
              return Problem("Entity set 'postgresContext.Servicos'  is null.");
          }
            _context.Servicos.Add(servico);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ServicoExists(servico.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetServico", new { id = servico.Id }, servico);
        }

        // DELETE: api/Servico/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteServico(int id)
        {
            if (_context.Servicos == null)
            {
                return NotFound();
            }
            var servico = await _context.Servicos.FindAsync(id);
            if (servico == null)
            {
                return NotFound();
            }

            _context.Servicos.Remove(servico);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ServicoExists(int id)
        {
            return (_context.Servicos?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
