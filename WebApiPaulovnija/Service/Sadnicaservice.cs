using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApiPaulovnija.Models;
using WebApiPaulovnija.DTO;

namespace WebApiPaulovnija.Services
{
    /// <summary>
    /// Servisna klasa za upravljanje sadnicama (Sadnica).
    /// </summary>
    public class SadnicaService : ISadnicaService
    {
        private readonly PaulovnijaContext _context;

        /// <summary>
        /// Inicijalizira novu instancu <see cref="SadnicaService"/> klase.
        /// </summary>
        /// <param name="context">Kontext baze podataka koji se koristi za interakciju s bazom podataka.</param>
        public SadnicaService(PaulovnijaContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Dohvaća sve sadnice kao listu <see cref="SadnicaDTO"/>.
        /// </summary>
        /// <returns>Task koji predstavlja asinkronu operaciju. Rezultat taska sadrži kolekciju <see cref="SadnicaDTO"/>.</returns>
        public async Task<IEnumerable<SadnicaDTO>> GetAllAsync()
        {
            return await _context.Sadnice
                .Select(s => new SadnicaDTO
                {
                    ID_Sadnice = s.ID_Sadnice,
                    Vrsta = s.Vrsta,
                    Visina = s.Visina,
                    Starost = s.Starost,
                    Datum_sadnje = s.Datum_sadnje,
                    ID_Rasadnika = s.ID_Rasadnika
                }).ToListAsync();
        }

        /// <summary>
        /// Dohvaća sadnicu prema njenom ID-u.
        /// </summary>
        /// <param name="id">ID sadnice koja se treba dohvatiti.</param>
        /// <returns>Task koji predstavlja asinkronu operaciju. Rezultat taska sadrži <see cref="SadnicaDTO"/> za određenu sadnicu, ili null ako nije pronađena.</returns>
        public async Task<SadnicaDTO> GetByIdAsync(int id)
        {
            var sadnica = await _context.Sadnice.FindAsync(id);
            if (sadnica == null) return null;

            return new SadnicaDTO
            {
                ID_Sadnice = sadnica.ID_Sadnice,
                Vrsta = sadnica.Vrsta,
                Visina = sadnica.Visina,
                Starost = sadnica.Starost,
                Datum_sadnje = sadnica.Datum_sadnje,
                ID_Rasadnika = sadnica.ID_Rasadnika
            };
        }

        /// <summary>
        /// Dodaje novu sadnicu iz navedenog <see cref="KreirajSadnicuDTO"/>.
        /// </summary>
        /// <param name="sadnicaDTO">Podaci o novoj sadnici.</param>
        /// <returns>Task koji predstavlja asinkronu operaciju. Rezultat taska sadrži novu stvorenu <see cref="SadnicaDTO"/>.</returns>
        public async Task<SadnicaDTO> AddAsync(KreirajSadnicuDTO sadnicaDTO)
        {
            var sadnica = new Sadnica
            {
                Vrsta = sadnicaDTO.Vrsta,
                Visina = sadnicaDTO.Visina,
                Starost = sadnicaDTO.Starost,
                Datum_sadnje = sadnicaDTO.Datum_sadnje,
                ID_Rasadnika = sadnicaDTO.ID_Rasadnika
            };

            await _context.Sadnice.AddAsync(sadnica);
            await _context.SaveChangesAsync();

            return new SadnicaDTO
            {
                ID_Sadnice = sadnica.ID_Sadnice,
                Vrsta = sadnica.Vrsta,
                Visina = sadnica.Visina,
                Starost = sadnica.Starost,
                Datum_sadnje = sadnica.Datum_sadnje,
                ID_Rasadnika = sadnica.ID_Rasadnika
            };
        }

        /// <summary>
        /// Ažurira sadnicu na temelju navedenog <see cref="AzurirajSadnicuDTO"/>.
        /// </summary>
        /// <param name="sadnicaDTO">Podaci za ažuriranje sadnice.</param>
        /// <returns>Task koji predstavlja asinkronu operaciju. Rezultat taska je true ako je ažuriranje uspješno, inače false.</returns>
        public async Task<bool> UpdateAsync(AzurirajSadnicuDTO sadnicaDTO)
        {
            var sadnica = await _context.Sadnice.FindAsync(sadnicaDTO.ID_Sadnice);
            if (sadnica == null) return false;

            sadnica.Vrsta = sadnicaDTO.Vrsta;
            sadnica.Visina = sadnicaDTO.Visina;
            sadnica.Starost = sadnicaDTO.Starost;
            sadnica.Datum_sadnje = sadnicaDTO.DatumSadnje;
            sadnica.ID_Rasadnika = sadnicaDTO.ID_Rasadnika;

            _context.Sadnice.Update(sadnica);
            await _context.SaveChangesAsync();
            return true;
        }

        /// <summary>
        /// Briše sadnicu prema njenom ID-u.
        /// </summary>
        /// <param name="id">ID sadnice koja se treba izbrisati.</param>
        /// <returns>Task koji predstavlja asinkronu operaciju. Rezultat taska je true ako je brisanje uspješno, inače false.</returns>
        public async Task<bool> DeleteAsync(int id)
        {
            var sadnica = await _context.Sadnice.FindAsync(id);
            if (sadnica == null) return false;

            _context.Sadnice.Remove(sadnica);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}
