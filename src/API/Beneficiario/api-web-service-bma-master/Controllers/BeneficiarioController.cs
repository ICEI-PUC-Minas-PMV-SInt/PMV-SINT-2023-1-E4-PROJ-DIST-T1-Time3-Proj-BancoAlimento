using api_web_service_bma.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api_web_service_bma.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class BeneficiarioController : ControllerBase
    {
        private readonly AppDbContext _context;
        public BeneficiarioController(AppDbContext context)

        {
            _context = context;
        }
        /// <summary>
        /// Listar todos os Beneficiários no Sistema
        /// </summary>
        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var model = await _context.Beneficiarios.ToListAsync();
            return Ok(model);
        }

        /// <summary>
        /// Criar cadastro de um Beneficiário no Sistema
        /// </summary>
        [HttpPost]
        public async Task<ActionResult> Create(Beneficiario model)
        {
            _context.Beneficiarios.Add(model);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetById", new { id = model.Id }, model );
        }

        /// <summary>
        /// Mostrar cadastro de um Beneficiário específico no Sistema
        /// </summary>
        [HttpGet("{id}")]
        public async Task<ActionResult> GetById(int id)
        {
            var model = await _context.Beneficiarios.AsNoTracking()
                .FirstOrDefaultAsync(c => c.Id == id);

            if (model == null) NotFound();
            return Ok(model);
        }

        /// <summary>
        /// Atualizar cadastro de um Beneficiário específico no Sistema
        /// </summary>
        [HttpPut("{id}")]

        public async Task<ActionResult> Update(int id, Beneficiario model)
        {
            if (id != model.Id) return BadRequest();
            var modeloDb = await _context.Beneficiarios.AsNoTracking()
                .FirstOrDefaultAsync(c => c.Id == id);

            if (modeloDb==null) return NotFound();

            _context.Beneficiarios.Update(model);
            await _context.SaveChangesAsync();

            return NoContent();
        }
        /// <summary>
        /// Excluir cadastro de um Beneficiário específico no Sistema
        /// </summary>
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete (int id) 
        {
            var model = await _context.Beneficiarios.FindAsync(id);

            if (model == null) NotFound();

            _context.Beneficiarios.Remove(model);
            await _context.SaveChangesAsync();

            return NoContent();
      
        }
    }
}
