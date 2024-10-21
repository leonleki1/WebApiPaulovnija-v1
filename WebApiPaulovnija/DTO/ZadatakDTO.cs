namespace WebApiPaulovnija.DTO
{
    /// <summary>
    /// DTO klasa koja predstavlja zadatak.
    /// </summary>
    public class ZadatakDTO
    {
        /// <summary>
        /// Jedinstveni identifikator zadatka.
        /// </summary>
        public int ID_Zadatka { get; set; }

        /// <summary>
        /// Opis zadatka.
        /// </summary>
        public string Opis { get; set; }

        /// <summary>
        /// Datum kada zadatak počinje.
        /// </summary>
        public DateTime Datum_pocetka { get; set; }

        /// <summary>
        /// Datum kada zadatak treba da bude završen.
        /// </summary>
        public DateTime Datum_zavrsetka { get; set; }

        /// <summary>
        /// Status zadatka (npr. u toku, završen).
        /// </summary>
        public string Status_Zadatka { get; set; }

        /// <summary>
        /// Jedinstveni identifikator radnika koji je dodeljen zadatku.
        /// </summary>
        public int ID_Radnika { get; set; }
    }
}
