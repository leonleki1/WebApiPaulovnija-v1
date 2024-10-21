using System.Collections.Generic;
using System.Threading.Tasks;
using WebApiPaulovnija.DTO; // Provjerite naziv prostora imena
using WebApiPaulovnija.Models;

namespace WebApiPaulovnija.Services
{
    /// <summary>
    /// Interfejs za radne operacije vezane za rasadnike.
    /// </summary>
    public interface IRasadnikService
    {
        /// <summary>
        /// Dohvata sve rasadnike asinhrono.
        /// </summary>
        /// <returns>Lista DTO objekata svih rasadnika.</returns>
        Task<IEnumerable<RasadnikDTO>> GetAllRasadniciAsync();

        /// <summary>
        /// Dohvata rasadnik po ID-ju asinhrono.
        /// </summary>
        /// <param name="id">Jedinstveni identifikator rasadnika.</param>
        /// <returns>DTO objekat rasadnika ili null ako nije pronađen.</returns>
        Task<RasadnikDTO> GetRasadnikByIdAsync(int id);

        /// <summary>
        /// Kreira novi rasadnik asinhrono.
        /// </summary>
        /// <param name="rasadnikDTO">DTO objekat rasadnika koji se kreira.</param>
        /// <returns>DTO objekat novog rasadnika.</returns>
        Task<RasadnikDTO> CreateRasadnikAsync(KreirajRasadnikDTO rasadnikDTO);

        /// <summary>
        /// Ažurira podatke rasadnika asinhrono.
        /// </summary>
        /// <param name="rasadnik">DTO objekat rasadnika sa ažuriranim podacima.</param>
        /// <returns>True ako je ažuriranje uspešno, inače False.</returns>
        Task<bool> UpdateRasadnikAsync(AzurirajRasadnikDTO rasadnik);

        /// <summary>
        /// Briše rasadnik po ID-ju asinhrono.
        /// </summary>
        /// <param name="id">Jedinstveni identifikator rasadnika koji se briše.</param>
        /// <returns>True ako je brisanje uspešno, inače False.</returns>
        Task<bool> DeleteRasadnikAsync(int id);
    }
}
