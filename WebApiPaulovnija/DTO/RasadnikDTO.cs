/// <summary>
/// DTO klasa koja predstavlja rasadnik.
/// </summary>
public class RasadnikDTO
{
    /// <summary>
    /// Jedinstveni identifikator rasadnika.
    /// </summary>
    public int ID_Rasadnika { get; set; }

    /// <summary>
    /// Naziv rasadnika.
    /// </summary>
    public string Naziv { get; set; }

    /// <summary>
    /// Lokacija rasadnika.
    /// </summary>
    public string Lokacija { get; set; }

    /// <summary>
    /// Površina rasadnika u kvadratnim metrima.
    /// </summary>
    public decimal Povrsina { get; set; }

    /// <summary>
    /// Datum otvaranja rasadnika.
    /// </summary>
    public DateTime Datum_otvaranja { get; set; }
}
