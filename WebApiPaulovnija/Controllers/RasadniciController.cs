using Microsoft.AspNetCore.Mvc;
using WebApiPaulovnija.Models;
using WebApiPaulovnija.Services;
using System.Threading.Tasks;
using WebApiPaulovnija.DTO;
using Microsoft.AspNetCore.Authorization;

namespace WebApiPaulovnija.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class RasadniciController : ControllerBase
    {
        private readonly IRasadnikService _rasadnikService;

        public RasadniciController(IRasadnikService rasadnikService)
        {
            _rasadnikService = rasadnikService;
        }

        /// <summary>
        /// Vraća sve rasadnike iz baze podataka.
        /// </summary>
        /// <returns>Lista rasadnika.</returns>
        [HttpGet]
        public async Task<IActionResult> GetRasadnici()
        {
            try
            {
                var rasadnici = await _rasadnikService.GetAllRasadniciAsync();
                return Ok(rasadnici);
            }
            catch
            {
                return StatusCode(500, "Internal server error");
            }
        }

        /// <summary>
        /// Vraća rasadnik po ID-u.
        /// </summary>
        /// <param name="id">ID rasadnika.</param>
        /// <returns>Rasadnik sa traženim ID-em.</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetRasadnik(int id)
        {
            var rasadnik = await _rasadnikService.GetRasadnikByIdAsync(id);
            if (rasadnik == null) return NotFound();
            return Ok(rasadnik);
        }

        /// <summary>
        /// Dodaje novog rasadnika u bazu podataka.
        /// </summary>
        /// <param name="rasadnikDTO">DTO objekt rasadnika koji se dodaje.</param>
        /// <returns>Status rezultata unosa.</returns>
        [HttpPost]
        public async Task<IActionResult> CreateRasadnik([FromBody] KreirajRasadnikDTO rasadnikDTO)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var createdRasadnik = await _rasadnikService.CreateRasadnikAsync(rasadnikDTO);
            return CreatedAtAction(nameof(GetRasadnik), new { id = createdRasadnik.ID_Rasadnika }, createdRasadnik);
        }

        /// <summary>
        /// Ažurira postojeći rasadnik u bazi podataka.
        /// </summary>
        /// <param name="id">ID rasadnika koji se ažurira.</param>
        /// <param name="rasadnikDTO">DTO objekt sa novim podacima rasadnika.</param>
        /// <returns>Status ažuriranja.</returns>
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateRasadnik(int id, [FromBody] AzurirajRasadnikDTO rasadnikDTO)
        {
            if (id != rasadnikDTO.ID_Rasadnika) return BadRequest();
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var updated = await _rasadnikService.UpdateRasadnikAsync(rasadnikDTO);
            if (!updated) return NotFound();
            return NoContent();
        }

        /// <summary>
        /// Briše rasadnik iz baze podataka.
        /// </summary>
        /// <param name="id">ID rasadnika koji se briše.</param>
        /// <returns>Status brisanja.</returns>
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRasadnik(int id)
        {
            var deleted = await _rasadnikService.DeleteRasadnikAsync(id);
            if (!deleted) return NotFound();
            return NoContent();
        }
    }
}
