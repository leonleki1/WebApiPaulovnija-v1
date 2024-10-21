using System.ComponentModel.DataAnnotations;

namespace WebApiPaulovnija.DTO
{
    /// <summary>
    /// DTO klasa za ažuriranje podataka o radniku.
    /// </summary>
    public class AzurirajRadnikaDTO
    {
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
        /// Pozicija na kojoj radnik radi.
        /// </summary>
        public string Pozicija { get; set; }

        /// <summary>
        /// Plata radnika.
        /// </summary>
        public decimal Plata { get; set; }
    }
}
