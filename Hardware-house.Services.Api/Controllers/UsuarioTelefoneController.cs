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
    public class UsuarioTelefoneController : ControllerBase
    {
        private readonly postgresContext _context;

        public UsuarioTelefoneController(postgresContext context)
        {
            _context = context;
        }

        // GET: api/UsuarioTelefone
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UsuarioTelefone>>> GetUsuarioTelefones()
        {
          if (_context.UsuarioTelefones == null)
          {
              return NotFound();
          }
            return await _context.UsuarioTelefones.ToListAsync();
        }

        // GET: api/UsuarioTelefone/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UsuarioTelefone>> GetUsuarioTelefone(string id)
        {
          if (_context.UsuarioTelefones == null)
          {
              return NotFound();
          }
            var usuarioTelefone = await _context.UsuarioTelefones.FindAsync(id);

            if (usuarioTelefone == null)
            {
                return NotFound();
            }

            return usuarioTelefone;
        }

        // PUT: api/UsuarioTelefone/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUsuarioTelefone(string id, UsuarioTelefone usuarioTelefone)
        {
            if (id != usuarioTelefone.Email)
            {
                return BadRequest();
            }

            _context.Entry(usuarioTelefone).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UsuarioTelefoneExists(id))
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

        // POST: api/UsuarioTelefone
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<UsuarioTelefone>> PostUsuarioTelefone(UsuarioTelefone usuarioTelefone)
        {
          if (_context.UsuarioTelefones == null)
          {
              return Problem("Entity set 'postgresContext.UsuarioTelefones'  is null.");
          }
            _context.UsuarioTelefones.Add(usuarioTelefone);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (UsuarioTelefoneExists(usuarioTelefone.Email))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetUsuarioTelefone", new { id = usuarioTelefone.Email }, usuarioTelefone);
        }

        // DELETE: api/UsuarioTelefone/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUsuarioTelefone(string id)
        {
            if (_context.UsuarioTelefones == null)
            {
                return NotFound();
            }
            var usuarioTelefone = await _context.UsuarioTelefones.FindAsync(id);
            if (usuarioTelefone == null)
            {
                return NotFound();
            }

            _context.UsuarioTelefones.Remove(usuarioTelefone);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool UsuarioTelefoneExists(string id)
        {
            return (_context.UsuarioTelefones?.Any(e => e.Email == id)).GetValueOrDefault();
        }
    }
}
