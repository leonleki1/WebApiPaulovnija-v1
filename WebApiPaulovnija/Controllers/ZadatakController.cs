using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApiPaulovnija.DTO;
using WebApiPaulovnija.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace WebApiPaulovnija.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    [Authorize]
    public class ZadatakController : ControllerBase
    {
        private readonly IZadatakService _zadatakService;
        private readonly IMapper _mapper;
        private readonly ILogger<ZadatakController> _logger;

        public ZadatakController(IZadatakService zadatakService, IMapper mapper, ILogger<ZadatakController> logger)
        {
            _zadatakService = zadatakService;
            _mapper = mapper;
            _logger = logger;
        }

        /// <summary>
        /// Vraća sve zadatke iz baze podataka.
        /// </summary>
        /// <returns>Lista zadataka.</returns>
        [HttpGet]
        public async Task<ActionResult<List<ZadatakDTO>>> Get()
        {
            try
            {
                var zadaci = await _zadatakService.GetAllZadaciAsync();
                return Ok(zadaci);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Greška prilikom dobavljanja svih zadataka.");
                return StatusCode(StatusCodes.Status500InternalServerError, new { poruka = "Greška na serveru prilikom dobavljanja zadataka." });
            }
        }

        /// <summary>
        /// Vraća zadatak po ID-u.
        /// </summary>
        /// <param name="id">ID zadatka.</param>
        /// <returns>Zadatak sa traženim ID-em.</returns>
        [HttpGet("{id:int}")]
        public async Task<ActionResult<ZadatakDTO>> GetById(int id)
        {
            try
            {
                var zadatak = await _zadatakService.GetZadatakByIdAsync(id);
                if (zadatak == null)
                {
                    return NotFound(new { poruka = "Zadatak sa datim ID-em nije pronađen." });
                }
                return Ok(zadatak);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Greška prilikom dobavljanja zadatka sa ID-jem {id}.");
                return StatusCode(StatusCodes.Status500InternalServerError, new { poruka = "Greška na serveru prilikom dobavljanja zadatka." });
            }
        }

        /// <summary>
        /// Dodaje novi zadatak u bazu podataka.
        /// </summary>
        /// <param name="dto">DTO objekt za novi zadatak.</param>
        /// <returns>Status rezultata unosa.</returns>
        [HttpPost]
        public async Task<IActionResult> Post(KreirajZadatakDTO dto)
        {
            if (!ModelState.IsValid) return BadRequest(new { poruka = "Neispravan model.", detalji = ModelState });

            try
            {
                var zadatak = await _zadatakService.CreateZadatakAsync(dto);
                return CreatedAtAction(nameof(GetById), new { id = zadatak.ID_Zadatka }, zadatak);
            }
            catch (DbUpdateException ex)
            {
                var innerException = ex.InnerException?.Message ?? ex.Message;
                _logger.LogError(ex, "Greška prilikom kreiranja zadatka.");
                return StatusCode(StatusCodes.Status500InternalServerError, new { poruka = "Greška na serveru prilikom kreiranja zadatka.", detalji = innerException });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Greška prilikom kreiranja zadatka.");
                return StatusCode(StatusCodes.Status500InternalServerError, new { poruka = "Greška na serveru prilikom kreiranja zadatka.", detalji = ex.Message });
            }
        }

        /// <summary>
        /// Ažurira postojeći zadatak u bazi podataka.
        /// </summary>
        /// <param name="id">ID zadatka koji se ažurira.</param>
        /// <param name="dto">DTO objekt sa novim podacima zadatka.</param>
        /// <returns>Status ažuriranja.</returns>
        [HttpPut("{id:int}")]
        public async Task<IActionResult> Put(int id, AzurirajZadatakDTO dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(new { poruka = "Neispravan model.", detalji = ModelState });

            try
            {
                var existingZadatak = await _zadatakService.GetZadatakByIdAsync(id);
                if (existingZadatak == null)
                {
                    return NotFound(new { poruka = "Zadatak sa datim ID-em nije pronađen." });
                }

                dto.ID_Zadatka = id;
                var result = await _zadatakService.UpdateZadatakAsync(dto);
                if (!result)
                {
                    return NotFound(new { poruka = "Zadatak sa datim ID-em nije pronađen." });
                }

                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Greška prilikom ažuriranja zadatka sa ID-jem {id}.");
                return StatusCode(StatusCodes.Status500InternalServerError, new { poruka = "Greška na serveru prilikom ažuriranja zadatka.", detalji = ex.Message });
            }
        }

        /// <summary>
        /// Briše zadatak iz baze podataka.
        /// </summary>
        /// <param name="id">ID zadatka koji se briše.</param>
        /// <returns>Status brisanja.</returns>
        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var result = await _zadatakService.DeleteZadatakAsync(id);
                if (!result)
                {
                    return NotFound(new { poruka = "Zadatak sa datim ID-em nije pronađen." });
                }
                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, $"Greška prilikom brisanja zadatka sa ID-jem {id}.");
                return StatusCode(StatusCodes.Status500InternalServerError, new { poruka = "Greška na serveru prilikom brisanja zadatka.", detalji = ex.Message });
            }
        }
    }
}
