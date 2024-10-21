using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace WebApiPaulovnija.DTO
{
    /// <summary>
    /// DTO klasa za ažuriranje informacija o rasadniku.
    /// </summary>
    public class AzurirajRasadnikDTO
    {
        /// <summary>
        /// Jedinstveni identifikator rasadnika.
        /// </summary>
        [Required]
        [JsonPropertyName("id_rasadnika")]
        public int ID_Rasadnika { get; set; }

        /// <summary>
        /// Naziv rasadnika, ne može biti duži od 100 znakova.
        /// </summary>
        [Required]
        [StringLength(100, ErrorMessage = "Naziv ne može biti duži od 100 znakova.")]
        [JsonPropertyName("naziv")]
        public string Naziv { get; set; }

        /// <summary>
        /// Lokacija rasadnika, ne može biti duža od 100 znakova.
        /// </summary>
        [Required]
        [StringLength(100, ErrorMessage = "Lokacija ne može biti duža od 100 znakova.")]
        [JsonPropertyName("lokacija")]
        public string Lokacija { get; set; }

        /// <summary>
        /// Površina rasadnika u kvadratnim metrima, mora biti pozitivna vrednost.
        /// </summary>
        [Required]
        [Range(0, double.MaxValue, ErrorMessage = "Površina mora biti pozitivna.")]
        [JsonPropertyName("povrsina")]
        public decimal Povrsina { get; set; }

        /// <summary>
        /// Datum otvaranja rasadnika.
        /// </summary>
        [Required]
        [JsonPropertyName("datum_otvaranja")]
        public DateTime Datum_otvaranja { get; set; } // Datum otvaranja rasadnika
    }
}
