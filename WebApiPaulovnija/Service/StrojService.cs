using System.Collections.Generic;
using System.Threading.Tasks;
using WebApiPaulovnija.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApiPaulovnija.Services
{
    /// <summary>
    /// Servisna klasa za upravljanje strojevima (Stroj).
    /// </summary>
    public class StrojService : IStrojService
    {
        private readonly PaulovnijaContext _context;

        /// <summary>
        /// Inicijalizira novu instancu <see cref="StrojService"/> klase.
        /// </summary>
        /// <param name="context">Kontext baze podataka koji se koristi za interakciju s bazom podataka.</param>
        public StrojService(PaulovnijaContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Dohvaća sve strojeve kao listu <see cref="Stroj"/>.
        /// </summary>
        /// <returns>Task koji predstavlja asinkronu operaciju. Rezultat taska sadrži kolekciju <see cref="Stroj"/>.</returns>
        public async Task<IEnumerable<Stroj>> GetAllAsync()
        {
            return await _context.Strojevi.ToListAsync();
        }

        /// <summary>
        /// Dohvaća stroj prema njegovom ID-u.
        /// </summary>
        /// <param name="id">ID stroja koji se treba dohvatiti.</param>
        /// <returns>Task koji predstavlja asinkronu operaciju. Rezultat taska sadrži <see cref="Stroj"/> za određeni stroj, ili null ako nije pronađen.</returns>
        public async Task<Stroj> GetByIdAsync(int id)
        {
            return await _context.Strojevi.FindAsync(id);
        }

        /// <summary>
        /// Dodaje novi stroj u bazu podataka.
        /// </summary>
        /// <param name="stroj">Instanca <see cref="Stroj"/> koja se dodaje.</param>
        /// <returns>Task koji predstavlja asinkronu operaciju.</returns>
        public async Task AddAsync(Stroj stroj)
        {
            await _context.Strojevi.AddAsync(stroj);
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Ažurira postojeći stroj u bazi podataka.
        /// </summary>
        /// <param name="stroj">Instanca <see cref="Stroj"/> koja se ažurira.</param>
        /// <returns>Task koji predstavlja asinkronu operaciju.</returns>
        public async Task UpdateAsync(Stroj stroj)
        {
            _context.Strojevi.Update(stroj);
            await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Briše stroj prema njegovom ID-u iz baze podataka.
        /// </summary>
        /// <param name="id">ID stroja koji se treba izbrisati.</param>
        /// <returns>Task koji predstavlja asinkronu operaciju.</returns>
        public async Task DeleteAsync(int id)
        {
            var stroj = await _context.Strojevi.FindAsync(id);
            if (stroj != null)
            {
                _context.Strojevi.Remove(stroj);
                await _context.SaveChangesAsync();
            }
        }
    }
}
