/// <summary>
/// DTO klasa koja predstavlja sadnicu.
/// </summary>
public class SadnicaDTO
{
    /// <summary>
    /// Jedinstveni identifikator sadnice.
    /// </summary>
    public int ID_Sadnice { get; set; }

    /// <summary>
    /// Vrsta sadnice (npr. drvo, biljka).
    /// </summary>
    public string Vrsta { get; set; }

    /// <summary>
    /// Visina sadnice u metrima.
    /// </summary>
    public decimal Visina { get; set; }

    /// <summary>
    /// Starost sadnice u godinama.
    /// </summary>
    public int Starost { get; set; }

    /// <summary>
    /// Datum sadnje sadnice.
    /// </summary>
    public DateTime Datum_sadnje { get; set; }

    /// <summary>
    /// Identifikator rasadnika u kojem se sadnica nalazi.
    /// </summary>
    public int ID_Rasadnika { get; set; }
}
