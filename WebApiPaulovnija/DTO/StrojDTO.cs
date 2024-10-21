/// <summary>
/// DTO klasa koja predstavlja stroj.
/// </summary>
public class StrojDTO
{
    /// <summary>
    /// Jedinstveni identifikator stroja.
    /// </summary>
    public int ID_Stroja { get; set; }

    /// <summary>
    /// Marka stroja (npr. John Deere, Case).
    /// </summary>
    public string Marka { get; set; }

    /// <summary>
    /// Model stroja (npr. 1234, XYZ).
    /// </summary>
    public string Model { get; set; }

    /// <summary>
    /// Godina proizvodnje stroja.
    /// </summary>
    public int Godiste { get; set; }

    /// <summary>
    /// Tip stroja (npr. traktorski, berba).
    /// </summary>
    public string Tip { get; set; }

    /// <summary>
    /// Kapacitet rezervoara u litrama.
    /// </summary>
    public decimal Kapacitet_rezervoara { get; set; }

    /// <summary>
    /// Jedinstveni identifikator radnika koji je dodeljen ovom stroju.
    /// </summary>
    public int ID_Radnika { get; set; }
}
