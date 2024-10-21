using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApiPaulovnija.DTO; // Provjerite je li ovo pravi prostor imena
using WebApiPaulovnija.Models;

namespace WebApiPaulovnija.Services
{
    /// <summary>
    /// Servisna klasa za upravljanje rasadnicima (Rasadnik).
    /// </summary>
    public class RasadnikService : IRasadnikService
    {
        private readonly PaulovnijaContext _context;

        /// <summary>
        /// Inicijalizira novu instancu <see cref="RasadnikService"/> klase.
        /// </summary>
        /// <param name="context">Kontext baze podataka koji se koristi za interakciju s bazom podataka.</param>
        public RasadnikService(PaulovnijaContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Dohvaća sve rasadnike kao listu <see cref="RasadnikDTO"/>.
        /// </summary>
        /// <returns>Task koji predstavlja asinkronu operaciju. Rezultat taska sadrži kolekciju <see cref="RasadnikDTO"/>.</returns>
        public async Task<IEnumerable<RasadnikDTO>> GetAllRasadniciAsync()
        {
            return await _context.Rasadnik
                .Select(r => new RasadnikDTO
                {
                    ID_Rasadnika = r.ID_Rasadnika,
                    Naziv = r.Naziv,
                    Lokacija = r.Lokacija,
                    // Dodajte ostala svojstva prema potrebama
                }).ToListAsync();
        }

        /// <summary>
        /// Dohvaća rasadnik prema njegovom ID-u.
        /// </summary>
        /// <param name="id">ID rasadnika koji treba dohvatiti.</param>
        /// <returns>Task koji predstavlja asinkronu operaciju. Rezultat taska sadrži <see cref="RasadnikDTO"/> za određeni rasadnik, ili null ako nije pronađen.</returns>
        public async Task<RasadnikDTO> GetRasadnikByIdAsync(int id)
        {
            var rasadnik = await _context.Rasadnik.FindAsync(id);
            if (rasadnik == null) return null;

            return new RasadnikDTO
            {
                ID_Rasadnika = rasadnik.ID_Rasadnika,
                Naziv = rasadnik.Naziv,
                Lokacija = rasadnik.Lokacija,
                // Dodajte ostala svojstva prema potrebama
            };
        }

        /// <summary>
        /// Stvara novi rasadnik iz navedenog <see cref="KreirajRasadnikDTO"/>.
        /// </summary>
        /// <param name="rasadnikDTO">Podaci o novom rasadniku.</param>
        /// <returns>Task koji predstavlja asinkronu operaciju. Rezultat taska sadrži novi stvoreni <see cref="RasadnikDTO"/>.</returns>
        public async Task<RasadnikDTO> CreateRasadnikAsync(KreirajRasadnikDTO rasadnikDTO)
        {
            var rasadnik = new Rasadnik
            {
                Naziv = rasadnikDTO.Naziv,
                Lokacija = rasadnikDTO.Lokacija,
                // Dodajte ostala svojstva prema potrebama
            };

            await _context.Rasadnik.AddAsync(rasadnik);
            await _context.SaveChangesAsync();

            return new RasadnikDTO
            {
                ID_Rasadnika = rasadnik.ID_Rasadnika,
                Naziv = rasadnik.Naziv,
                Lokacija = rasadnik.Lokacija,
                // Dodajte ostala svojstva prema potrebama
            };
        }

        /// <summary>
        /// Ažurira rasadnik na temelju navedenog <see cref="AzurirajRasadnikDTO"/>.
        /// </summary>
        /// <param name="rasadnikDTO">Podaci za ažuriranje rasadnika.</param>
        /// <returns>Task koji predstavlja asinkronu operaciju. Rezultat taska je true ako je ažuriranje uspješno, inače false.</returns>
        public async Task<bool> UpdateRasadnikAsync(AzurirajRasadnikDTO rasadnikDTO)
        {
            var rasadnik = await _context.Rasadnik.FindAsync(rasadnikDTO.ID_Rasadnika);
            if (rasadnik == null) return false;

            // Ažurirajte svojstva rasadnika
            rasadnik.Naziv = rasadnikDTO.Naziv;
            rasadnik.Lokacija = rasadnikDTO.Lokacija;
            // Dodajte ostala svojstva prema potrebama

            _context.Rasadnik.Update(rasadnik);
            await _context.SaveChangesAsync();
            return true;
        }

        /// <summary>
        /// Briše rasadnik prema njegovom ID-u.
        /// </summary>
        /// <param name="id">ID rasadnika koji treba izbrisati.</param>
        /// <returns>Task koji predstavlja asinkronu operaciju. Rezultat taska je true ako je brisanje uspješno, inače false.</returns>
        public async Task<bool> DeleteRasadnikAsync(int id)
        {
            var rasadnik = await _context.Rasadnik.FindAsync(id);
            if (rasadnik == null) return false;

            _context.Rasadnik.Remove(rasadnik); // Ispravka ovdje
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
