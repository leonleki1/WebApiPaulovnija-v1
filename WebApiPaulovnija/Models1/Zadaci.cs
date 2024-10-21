using System;

namespace WebApiPaulovnija.Models
{
    /// <summary>
    /// Klasa koja predstavlja zadatak.
    /// </summary>
    public class Zadatak
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
        /// Datum početka zadatka.
        /// </summary>
        public DateTime Datum_pocetka { get; set; }

        /// <summary>
        /// Datum završetka zadatka.
        /// </summary>
        public DateTime Datum_zavrsetka { get; set; }

        /// <summary>
        /// Status zadatka (npr. "u toku", "završen").
        /// </summary>
        public string Status_Zadatka { get; set; }

        /// <summary>
        /// Jedinstveni identifikator radnika koji je dodeljen zadatku.
        /// </summary>
        public int ID_Radnika { get; set; }

        /// <summary>
        /// Referenca na radnika koji je dodeljen zadatku.
        /// </summary>
        public Radnik Radnik { get; set; }
    }
}
