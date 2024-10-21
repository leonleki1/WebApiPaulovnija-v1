using System.ComponentModel.DataAnnotations;

public class KreirajZadatakDTO
{
    /// <summary>
    /// Opis zadatka. Ovo polje je obavezno.
    /// </summary>
    [Required(ErrorMessage = "Opis zadatka je obavezan.")]
    public string Opis { get; set; }

    /// <summary>
    /// Datum kada zadatak počinje. Ovo polje je obavezno.
    /// </summary>
    [Required(ErrorMessage = "Datum početka zadatka je obavezan.")]
    public DateTime Datum_pocetka { get; set; }

    /// <summary>
    /// Datum kada zadatak treba da bude završen. Ovo polje je obavezno.
    /// </summary>
    [Required(ErrorMessage = "Datum završetka zadatka je obavezan.")]
    public DateTime Datum_zavrsetka { get; set; }

    /// <summary>
    /// Status zadatka (npr. u toku, završen). Ovo polje je obavezno.
    /// </summary>
    [Required(ErrorMessage = "Status zadatka je obavezan.")]
    public string Status_Zadatka { get; set; }

    /// <summary>
    /// Jedinstveni identifikator radnika kome je zadatak dodeljen. Ovo polje je obavezno.
    /// </summary>
    [Required(ErrorMessage = "ID radnika je obavezan.")]
    public int ID_Radnika { get; set; }
}
