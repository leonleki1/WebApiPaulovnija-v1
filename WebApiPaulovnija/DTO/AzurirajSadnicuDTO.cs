namespace WebApiPaulovnija.DTO
{
    /// <summary>
    /// DTO klasa za ažuriranje informacija o sadnici.
    /// </summary>
    public class AzurirajSadnicuDTO
    {
        /// <summary>
        /// Jedinstveni identifikator sadnice.
        /// </summary>
        public int ID_Sadnice { get; set; }

        /// <summary>
        /// Vrsta sadnice.
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
        public DateTime DatumSadnje { get; set; }

        /// <summary>
        /// Identifikator rasadnika u kojem se sadnica nalazi.
        /// </summary>
        public int ID_Rasadnika { get; set; }
    }
}
