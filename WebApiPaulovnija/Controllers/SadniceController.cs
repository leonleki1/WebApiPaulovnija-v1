using Microsoft.AspNetCore.Mvc;
using WebApiPaulovnija.DTO;
using WebApiPaulovnija.Services;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace WebApiPaulovnija.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class SadniceController : ControllerBase
    {
        private readonly ISadnicaService _sadnicaService;

        public SadniceController(ISadnicaService sadnicaService)
        {
            _sadnicaService = sadnicaService;
        }

        /// <summary>
        /// Vraća sve sadnice iz baze podataka.
        /// </summary>
        /// <returns>Lista sadnica.</returns>
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var sadnice = await _sadnicaService.GetAllAsync();
            return Ok(sadnice);
        }

        /// <summary>
        /// Vraća sadnicu po ID-u.
        /// </summary>
        /// <param name="id">ID sadnice.</param>
        /// <returns>Sadnica sa traženim ID-em.</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var sadnica = await _sadnicaService.GetByIdAsync(id);
            if (sadnica == null) return NotFound();
            return Ok(sadnica);
        }

        /// <summary>
        /// Dodaje novu sadnicu u bazu podataka.
        /// </summary>
        /// <param name="sadnicaDTO">DTO objekt sadnice koji se dodaje.</param>
        /// <returns>Status rezultata unosa.</returns>
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] KreirajSadnicuDTO sadnicaDTO)
        {
            var createdSadnica = await _sadnicaService.AddAsync(sadnicaDTO);
            return CreatedAtAction(nameof(GetById), new { id = createdSadnica.ID_Sadnice }, createdSadnica);
        }

        /// <summary>
        /// Ažurira postojeću sadnicu u bazi podataka.
        /// </summary>
        /// <param name="id">ID sadnice koji se ažurira.</param>
        /// <param name="sadnicaDTO">DTO objekt sa novim podacima sadnice.</param>
        /// <returns>Status ažuriranja.</returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, [FromBody] AzurirajSadnicuDTO sadnicaDTO)
        {
            if (id != sadnicaDTO.ID_Sadnice) return BadRequest();
            var updated = await _sadnicaService.UpdateAsync(sadnicaDTO);
            if (!updated) return NotFound();
            return NoContent();
        }

        /// <summary>
        /// Briše sadnicu iz baze podataka.
        /// </summary>
        /// <param name="id">ID sadnice koji se briše.</param>
        /// <returns>Status brisanja.</returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var deleted = await _sadnicaService.DeleteAsync(id);
            if (!deleted) return NotFound();
            return NoContent();
        }
    }
}
