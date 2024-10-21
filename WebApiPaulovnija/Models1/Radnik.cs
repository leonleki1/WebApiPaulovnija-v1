using System.Collections.Generic;

namespace WebApiPaulovnija.Models
{
    /// <summary>
    /// Klasa koja predstavlja radnika.
    /// </summary>
    public class Radnik
    {
        /// <summary>
        /// Jedinstveni identifikator radnika.
        /// </summary>
        public int ID_Radnika { get; set; }

        /// <summary>
        /// Ime radnika.
        /// </summary>
        public string Ime { get; set; }

        /// <summary>
        /// Prezime radnika.
        /// </summary>
        public string Prezime { get; set; }

        /// <summary>
        /// Godine starosti radnika.
        /// </summary>
        public int Godine { get; set; }

        /// <summary>
        /// Pozicija radnika na poslu.
        /// </summary>
        public string Pozicija { get; set; }

        /// <summary>
        /// Plata radnika.
        /// </summary>
        public decimal Plata { get; set; }

        /// <summary>
        /// Lista zadataka dodeljenih radniku.
        /// </summary>
        public ICollection<Zadatak> Zadaci { get; set; }

        /// <summary>
        /// Lista strojeva kojima upravlja radnik.
        /// </summary>
        public ICollection<Stroj> Strojevi { get; set; }
    }
}
