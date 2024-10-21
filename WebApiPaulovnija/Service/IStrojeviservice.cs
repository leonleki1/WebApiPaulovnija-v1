using System.Collections.Generic;
using System.Threading.Tasks;
using WebApiPaulovnija.Models;

namespace WebApiPaulovnija.Services
{
    /// <summary>
    /// Interfejs za radne operacije vezane za strojeve.
    /// </summary>
    public interface IStrojService
    {
        /// <summary>
        /// Dohvata sve strojeve asinhrono.
        /// </summary>
        /// <returns>Lista svih strojeva.</returns>
        Task<IEnumerable<Stroj>> GetAllAsync();

        /// <summary>
        /// Dohvata stroj po ID-ju asinhrono.
        /// </summary>
        /// <param name="id">Jedinstveni identifikator stroja.</param>
        /// <returns>Instanca stroja ili null ako nije pronađena.</returns>
        Task<Stroj> GetByIdAsync(int id);

        /// <summary>
        /// Dodaje novi stroj asinhrono.
        /// </summary>
        /// <param name="stroj">Instanca stroja koja se dodaje.</param>
        Task AddAsync(Stroj stroj);

        /// <summary>
        /// Ažurira podatke stroja asinhrono.
        /// </summary>
        /// <param name="stroj">Instanca stroja sa ažuriranim podacima.</param>
        Task UpdateAsync(Stroj stroj);

        /// <summary>
        /// Briše stroj po ID-ju asinhrono.
        /// </summary>
        /// <param name="id">Jedinstveni identifikator stroja koji se briše.</param>
        Task DeleteAsync(int id);
    }
}
