using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace WebApiPaulovnija.Models
{
    /// <summary>
    /// Klasa koja predstavlja rasadnik.
    /// </summary>
    public class Rasadnik
    {
        /// <summary>
        /// Jedinstveni identifikator rasadnika.
        /// </summary>
        [JsonPropertyName("id_rasadnika")]
        public int ID_Rasadnika { get; set; }

        /// <summary>
        /// Naziv rasadnika.
        /// </summary>
        [JsonPropertyName("naziv")]
        public string Naziv { get; set; }

        /// <summary>
        /// Lokacija rasadnika.
        /// </summary>
        [JsonPropertyName("lokacija")]
        public string Lokacija { get; set; }

        /// <summary>
        /// Površina rasadnika u hektarima.
        /// </summary>
        [JsonPropertyName("povrsina")]
        public decimal Povrsina { get; set; }

        /// <summary>
        /// Datum otvaranja rasadnika.
        /// </summary>
        [JsonPropertyName("datum_otvaranja")]
        public DateTime Datum_otvaranja { get; set; }

        /// <summary>
        /// Lista sadnica u rasadniku.
        /// </summary>
        public ICollection<Sadnica> Sadnice { get; set; }
    }
}
