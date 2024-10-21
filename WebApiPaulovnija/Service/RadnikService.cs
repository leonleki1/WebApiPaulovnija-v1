using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApiPaulovnija.Models;

using WebApiPaulovnija.Services;

namespace WebApiPaulovnija.Service
{
    /// <summary>
    /// Implementacija servisa za upravljanje radnicima.
    /// </summary>
    public class RadnikService : IRadnikService
    {
        private readonly PaulovnijaContext _context;

        /// <summary>
        /// Inicijalizira novu instancu <see cref="RadnikService"/> klase.
        /// </summary>
        /// <param name="context">Kontekst baze podataka za pristup podacima o radnicima.</param>
        public RadnikService(PaulovnijaContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Vraća sve radnike iz baze podataka.
        /// </summary>
        /// <returns>Lista svih radnika.</returns>
        public List<Radnik> GetAllRadnici()
        {
            return _context.Radnici.ToList();
        }

        /// <summary>
        /// Vraća radnika na temelju ID-a.
        /// </summary>
        /// <param name="id">ID radnika koji se želi pretražiti.</param>
        /// <returns>Radnik ako je pronađen, inače null.</returns>
        public Radnik GetRadnikById(int id)
        {
            return _context.Radnici.Find(id);
        }

        /// <summary>
        /// Dodaje novog radnika u bazu podataka.
        /// </summary>
        /// <param name="radnik">Objekt radnika koji se dodaje.</param>
        public void CreateRadnik(Radnik radnik)
        {
            _context.Radnici.Add(radnik);
            _context.SaveChanges();
        }

        /// <summary>
        /// Ažurira postojećeg radnika u bazi podataka.
        /// </summary>
        /// <param name="radnik">Objekt radnika koji sadrži ažurirane podatke.</param>
        public void UpdateRadnik(Radnik radnik)
        {
            _context.Radnici.Update(radnik);
            _context.SaveChanges();
        }

        /// <summary>
        /// Briše radnika iz baze podataka.
        /// </summary>
        /// <param name="radnik">Objekt radnika koji se briše.</param>
        public void DeleteRadnik(Radnik radnik)
        {
            _context.Radnici.Remove(radnik);
            _context.SaveChanges();
        }

        /// <summary>
        /// Asinkrono dodaje novog radnika u bazu podataka.
        /// </summary>
        /// <param name="radnik">Objekt radnika koji se dodaje.</param>
        /// <returns>Vraća asinkroni rezultat operacije dodavanja.</returns>
        public async Task<Radnik> CreateRadnikAsync(Radnik radnik)
        {
            _context.Radnici.Add(radnik);
            await _context.SaveChangesAsync();
            return radnik;
        }

        /// <summary>
        /// Asinkrono vraća sve radnike iz baze podataka.
        /// </summary>
        /// <returns>Lista svih radnika.</returns>
        public async Task<List<Radnik>> GetAllRadniciAsync()
        {
            return await _context.Radnici.ToListAsync();
        }

        /// <summary>
        /// Asinkrono vraća radnika na temelju ID-a.
        /// </summary>
        /// <param name="id">ID radnika koji se želi pretražiti.</param>
        /// <returns>Radnik ako je pronađen, inače null.</returns>
        public async Task<Radnik> GetRadnikByIdAsync(int id)
        {
            return await _context.Radnici.FindAsync(id);
        }

        /// <summary>
        /// Asinkrono ažurira postojećeg radnika u bazi podataka.
        /// </summary>
        /// <param name="radnik">Objekt radnika koji sadrži ažurirane podatke.</param>
        /// <returns>True ako je ažuriranje uspješno, inače false.</returns>
        public async Task<bool> UpdateRadnikAsync(Radnik radnik)
        {
            _context.Radnici.Update(radnik);
            return await _context.SaveChangesAsync() > 0;
        }

        /// <summary>
        /// Asinkrono briše radnika iz baze podataka na temelju ID-a.
        /// </summary>
        /// <param name="id">ID radnika koji se briše.</param>
        /// <returns>True ako je radnik uspješno obrisan, inače false.</returns>
        public async Task<bool> DeleteRadnikAsync(int id)
        {
            var radnik = await _context.Radnici.FindAsync(id);
            if (radnik == null)
                return false;

            _context.Radnici.Remove(radnik);
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
