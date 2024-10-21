namespace WebApiPaulovnija.DTO
{
    /// <summary>
    /// DTO klasa za kreiranje novog stroja.
    /// </summary>
    public class KreirajStrojDTO
    {
        /// <summary>
        /// Marka stroja (npr. John Deere, Case IH).
        /// </summary>
        public string Marka { get; set; }

        /// <summary>
        /// Model stroja (npr. 5055E).
        /// </summary>
        public string Model { get; set; }

        /// <summary>
        /// Godina proizvodnje stroja.
        /// </summary>
        public int Godiste { get; set; }

        /// <summary>
        /// Tip stroja (npr. traktor, kombajn).
        /// </summary>
        public string Tip { get; set; }

        /// <summary>
        /// Kapacitet rezervoara u litrima.
        /// </summary>
        public decimal Kapacitet_rezervoara { get; set; }

        /// <summary>
        /// Identifikator radnika koji koristi stroj.
        /// </summary>
        public int ID_Radnika { get; set; }
    }
}
