using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CrudProjeto.Data;
using CrudProjeto.models;

namespace CrudProjeto.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClassificadorProjetoControllers : ControllerBase
    {
        private readonly DataContext _context;

        public ClassificadorProjetoControllers(DataContext context)
        {
            _context = context;
        }

        // GET: api/ClassificadorProjetoControllers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ClassificadorProjeto>>> GetAll()
        {
            return Ok(await _context.ClassificadoresProjeto.ToListAsync());
        }

        // GET: api/ClassificadorProjetoControllers/1
        [HttpGet("{id}")]
        public async Task<ActionResult<ClassificadorProjeto>> GetById(int id)
        {
            var item = await _context.ClassificadoresProjeto.FindAsync(id);
            if (item == null) return NotFound("Registro não encontrado.");
            return Ok(item);
        }

        // POST: api/ClassificadorProjetoControllers
        [HttpPost]
        public async Task<ActionResult<ClassificadorProjeto>> Create(ClassificadorProjeto novoItem)
        {
            _context.ClassificadoresProjeto.Add(novoItem);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetById), new { id = novoItem.Id }, novoItem);
        }

        // PUT: api/ClassificadorProjetoControllers/1
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, ClassificadorProjeto itemAtualizado)
        {
            if (id != itemAtualizado.Id) return BadRequest("IDs diferentes.");
            _context.Entry(itemAtualizado).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return Ok(itemAtualizado);
        }

        // DELETE: api/ClassificadorProjetoControllers/1
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var item = await _context.ClassificadoresProjeto.FindAsync(id);
            if (item == null) return NotFound("Registro não encontrado.");
            _context.ClassificadoresProjeto.Remove(item);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}


