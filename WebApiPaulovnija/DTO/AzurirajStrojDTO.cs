namespace WebApiPaulovnija.DTO
{
    /// <summary>
    /// DTO klasa za ažuriranje informacija o stroju.
    /// </summary>
    public class AzurirajStrojDTO
    {
        /// <summary>
        /// Jedinstveni identifikator stroja.
        /// </summary>
        public int ID_Stroja { get; set; }

        /// <summary>
        /// Marka stroja.
        /// </summary>
        public string Marka { get; set; }

        /// <summary>
        /// Model stroja.
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
