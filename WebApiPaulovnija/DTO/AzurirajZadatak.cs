using System.ComponentModel.DataAnnotations;

public class AzurirajZadatakDTO
{
    /// <summary>
    /// Jedinstveni identifikator zadatka koji se ažurira.
    /// </summary>
    public int ID_Zadatka { get; set; }

    /// <summary>
    /// Opis zadatka. Ovaj atribut je obavezan.
    /// </summary>
    [Required]
    public string Opis { get; set; }

    /// <summary>
    /// Datum kada zadatak počinje. Ovaj atribut je obavezan.
    /// </summary>
    [Required]
    public DateTime Datum_pocetka { get; set; }

    /// <summary>
    /// Datum kada zadatak treba da bude završen. Ovaj atribut je obavezan.
    /// </summary>
    [Required]
    public DateTime Datum_zavrsetka { get; set; }

    /// <summary>
    /// Status zadatka (npr. u toku, završen). Ovaj atribut je obavezan.
    /// </summary>
    [Required]
    public string Status_Zadatka { get; set; }

    /// <summary>
    /// Jedinstveni identifikator radnika kome je zadatak dodeljen. Ovaj atribut je obavezan.
    /// </summary>
    [Required]
    public int ID_Radnika { get; set; }
}
