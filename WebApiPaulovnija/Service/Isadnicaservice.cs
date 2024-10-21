using System.Collections.Generic;
using System.Threading.Tasks;
using WebApiPaulovnija.DTO; // Provjerite naziv prostora imena
using WebApiPaulovnija.Models;

namespace WebApiPaulovnija.Services
{
    /// <summary>
    /// Interfejs za radne operacije vezane za sadnice.
    /// </summary>
    public interface ISadnicaService
    {
        /// <summary>
        /// Dohvata sve sadnice asinhrono.
        /// </summary>
        /// <returns>Lista DTO objekata svih sadnica.</returns>
        Task<IEnumerable<SadnicaDTO>> GetAllAsync();

        /// <summary>
        /// Dohvata sadnicu po ID-ju asinhrono.
        /// </summary>
        /// <param name="id">Jedinstveni identifikator sadnice.</param>
        /// <returns>DTO objekat sadnice ili null ako nije pronađen.</returns>
        Task<SadnicaDTO> GetByIdAsync(int id);

        /// <summary>
        /// Dodaje novu sadnicu asinhrono.
        /// </summary>
        /// <param name="sadnicaDTO">DTO objekat sadnice koja se dodaje.</param>
        /// <returns>DTO objekat novog sadnice.</returns>
        Task<SadnicaDTO> AddAsync(KreirajSadnicuDTO sadnicaDTO);

        /// <summary>
        /// Ažurira podatke sadnice asinhrono.
        /// </summary>
        /// <param name="sadnicaDTO">DTO objekat sadnice sa ažuriranim podacima.</param>
        /// <returns>True ako je ažuriranje uspešno, inače False.</returns>
        Task<bool> UpdateAsync(AzurirajSadnicuDTO sadnicaDTO);

        /// <summary>
        /// Briše sadnicu po ID-ju asinhrono.
        /// </summary>
        /// <param name="id">Jedinstveni identifikator sadnice koja se briše.</param>
        /// <returns>True ako je brisanje uspešno, inače False.</returns>
        Task<bool> DeleteAsync(int id);
    }
}
