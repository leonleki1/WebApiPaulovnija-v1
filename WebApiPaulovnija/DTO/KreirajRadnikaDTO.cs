using System.ComponentModel.DataAnnotations;

namespace WebApiPaulovnija.DTO
{
    /// <summary>
    /// DTO klasa za kreiranje novog radnika.
    /// </summary>
    public class KreirajRadnikaDTO
    {
        /// <summary>
        /// Ime radnika. Ovo polje je obavezno.
        /// </summary>
        [Required(ErrorMessage = "Ime je obavezno.")]
        public string Ime { get; set; }

        /// <summary>
        /// Prezime radnika. Ovo polje je obavezno.
        /// </summary>
        [Required(ErrorMessage = "Prezime je obavezno.")]
        public string Prezime { get; set; }

        /// <summary>
        /// Godine starosti radnika. Ovo polje je obavezno.
        /// </summary>
        [Required(ErrorMessage = "Godine su obavezne.")]
        public int Godine { get; set; }

        /// <summary>
        /// Pozicija radnika na poslu. Ovo polje je obavezno.
        /// </summary>
        [Required(ErrorMessage = "Pozicija je obavezna.")]
        public string Pozicija { get; set; }

        /// <summary>
        /// Plata radnika. Ovo polje je obavezno.
        /// </summary>
        [Required(ErrorMessage = "Placa je obavezna.")]
        public decimal Plata { get; set; }
    }
}
