using WebApiPaulovnija.Models;

namespace WebApiPaulovnija.Models
{
    /// <summary>
    /// Klasa koja predstavlja stroj.
    /// </summary>
    public class Stroj
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
        /// Tip stroja.
        /// </summary>
        public string Tip { get; set; }

        /// <summary>
        /// Kapacitet rezervoara stroja u litrima.
        /// </summary>
        public decimal Kapacitet_rezervoara { get; set; }

        /// <summary>
        /// Jedinstveni identifikator radnika koji upravlja strojem.
        /// </summary>
        public int ID_Radnika { get; set; }

        /// <summary>
        /// Referenca na radnika koji upravlja strojem.
        /// </summary>
        public Radnik Radnik { get; set; }
    }
}
