using System.Collections.Generic;
using System.Threading.Tasks;
using WebApiPaulovnija.Models;

namespace WebApiPaulovnija.Services
{
    /// <summary>
    /// Interfejs za radne operacije vezane za radnike.
    /// </summary>
    public interface IRadnikService
    {
        /// <summary>
        /// Kreira novog radnika asinhrono.
        /// </summary>
        /// <param name="radnik">Instanca radnika koja se kreira.</param>
        /// <returns>Instanca novog radnika.</returns>
        Task<Radnik> CreateRadnikAsync(Radnik radnik);

        /// <summary>
        /// Dohvata sve radnike asinhrono.
        /// </summary>
        /// <returns>Lista svih radnika.</returns>
        Task<List<Radnik>> GetAllRadniciAsync();

        /// <summary>
        /// Dohvata radnika po ID-ju asinhrono.
        /// </summary>
        /// <param name="id">Jedinstveni identifikator radnika.</param>
        /// <returns>Instanca radnika ili null ako nije pronađen.</returns>
        Task<Radnik> GetRadnikByIdAsync(int id);

        /// <summary>
        /// Ažurira podatke radnika asinhrono.
        /// </summary>
        /// <param name="radnik">Instanca radnika sa ažuriranim podacima.</param>
        /// <returns>True ako je ažuriranje uspešno, inače False.</returns>
        Task<bool> UpdateRadnikAsync(Radnik radnik);

        /// <summary>
        /// Briše radnika po ID-ju asinhrono.
        /// </summary>
        /// <param name="id">Jedinstveni identifikator radnika koji se briše.</param>
        /// <returns>True ako je brisanje uspešno, inače False.</returns>
        Task<bool> DeleteRadnikAsync(int id);
    }
}
