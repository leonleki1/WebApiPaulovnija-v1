using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApiPaulovnija.DTO;
using WebApiPaulovnija.Models;

public class ZadatakService : IZadatakService
{
    private readonly PaulovnijaContext _context;
    private readonly IMapper _mapper;

    /// <summary>
    /// Inicijalizira novu instancu <see cref="ZadatakService"/> klase.
    /// </summary>
    /// <param name="context">Kontekst baze podataka za pristup bazi.</param>
    /// <param name="mapper">Instanca AutoMapper-a za mapiranje između entiteta i DTO-a.</param>
    public ZadatakService(PaulovnijaContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    /// <summary>
    /// Kreira novi zadatak (Zadatak).
    /// </summary>
    /// <param name="dto">DTO koji sadrži podatke o zadatku.</param>
    /// <returns>Kreirani zadatak kao <see cref="ZadatakDTO"/>.</returns>
    /// <exception cref="Exception">Baca se kada navedeni radnik ne postoji.</exception>
    public async Task<ZadatakDTO> CreateZadatakAsync(KreirajZadatakDTO dto)
    {
        var radnikExists = await _context.Radnici.AnyAsync(r => r.ID_Radnika == dto.ID_Radnika);
        if (!radnikExists)
        {
            throw new Exception("Radnik sa datim ID ne postoji.");
        }

        var zadatak = new Zadatak
        {
            Opis = dto.Opis,
            Datum_pocetka = dto.Datum_pocetka,
            Datum_zavrsetka = dto.Datum_zavrsetka,
            Status_Zadatka = dto.Status_Zadatka,
            ID_Radnika = dto.ID_Radnika
        };

        await _context.Zadaci.AddAsync(zadatak);
        await _context.SaveChangesAsync();

        var zadatakDTO = _mapper.Map<ZadatakDTO>(zadatak);
        return zadatakDTO;
    }

    /// <summary>
    /// Ažurira postojeći zadatak (Zadatak).
    /// </summary>
    /// <param name="dto">DTO koji sadrži ažurirane podatke o zadatku.</param>
    /// <returns>True ako je ažuriranje uspješno; inače, false.</returns>
    public async Task<bool> UpdateZadatakAsync(AzurirajZadatakDTO dto)
    {
        var zadatak = await _context.Zadaci.FindAsync(dto.ID_Zadatka);
        if (zadatak == null)
        {
            return false;
        }

        zadatak.Opis = dto.Opis;
        zadatak.Datum_pocetka = dto.Datum_pocetka;
        zadatak.Datum_zavrsetka = dto.Datum_zavrsetka;
        zadatak.Status_Zadatka = dto.Status_Zadatka;
        zadatak.ID_Radnika = dto.ID_Radnika;

        await _context.SaveChangesAsync();
        return true;
    }

    /// <summary>
    /// Briše zadatak (Zadatak) prema njegovom ID-u.
    /// </summary>
    /// <param name="id">ID zadatka koji treba obrisati.</param>
    /// <returns>True ako je zadatak uspješno obrisan; inače, false.</returns>
    public async Task<bool> DeleteZadatakAsync(int id)
    {
        var zadatak = await _context.Zadaci.FindAsync(id);
        if (zadatak == null)
        {
            return false;
        }

        _context.Zadaci.Remove(zadatak);
        await _context.SaveChangesAsync();
        return true;
    }

    /// <summary>
    /// Dohvaća sve zadatke (Zadaci).
    /// </summary>
    /// <returns>Lista zadataka kao <see cref="List{ZadatakDTO}"/>.</returns>
    public async Task<List<ZadatakDTO>> GetAllZadaciAsync()
    {
        var zadaci = await _context.Zadaci.ToListAsync();
        return _mapper.Map<List<ZadatakDTO>>(zadaci);
    }

    /// <summary>
    /// Dohvaća zadatak (Zadatak) prema njegovom ID-u.
    /// </summary>
    /// <param name="id">ID zadatka koji treba dohvatiti.</param>
    /// <returns>Zadatak kao <see cref="ZadatakDTO"/>.</returns>
    public async Task<ZadatakDTO> GetZadatakByIdAsync(int id)
    {
        var zadatak = await _context.Zadaci.FindAsync(id);
        return _mapper.Map<ZadatakDTO>(zadatak);
    }
}
