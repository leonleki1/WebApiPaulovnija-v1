using System.Collections.Generic;
using System.Threading.Tasks;
using WebApiPaulovnija.DTO;

public interface IZadatakService
{
    /// <summary>
    /// Kreira novi zadatak asinhrono.
    /// </summary>
    /// <param name="dto">DTO objekat sa podacima za kreiranje zadatka.</param>
    /// <returns>DTO objekat novog zadatka.</returns>
    Task<ZadatakDTO> CreateZadatakAsync(KreirajZadatakDTO dto);

    /// <summary>
    /// Ažurira postojeći zadatak asinhrono.
    /// </summary>
    /// <param name="dto">DTO objekat sa ažuriranim podacima zadatka.</param>
    /// <returns>True ako je ažuriranje uspešno, inače False.</returns>
    Task<bool> UpdateZadatakAsync(AzurirajZadatakDTO dto);

    /// <summary>
    /// Briše zadatak po ID-ju asinhrono.
    /// </summary>
    /// <param name="id">Jedinstveni identifikator zadatka koji se briše.</param>
    /// <returns>True ako je brisanje uspešno, inače False.</returns>
    Task<bool> DeleteZadatakAsync(int id);

    /// <summary>
    /// Dohvata sve zadatke asinhrono.
    /// </summary>
    /// <returns>Lista DTO objekata svih zadataka.</returns>
    Task<List<ZadatakDTO>> GetAllZadaciAsync();

    /// <summary>
    /// Dohvata zadatak po ID-ju asinhrono.
    /// </summary>
    /// <param name="id">Jedinstveni identifikator zadatka.</param>
    /// <returns>DTO objekat zadatka ili null ako nije pronađen.</returns>
    Task<ZadatakDTO> GetZadatakByIdAsync(int id);
}
