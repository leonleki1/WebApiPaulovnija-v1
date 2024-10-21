using System;
using System.ComponentModel.DataAnnotations;
using WebApiPaulovnija.Models;

namespace WebApiPaulovnija.Models
{
    /// <summary>
    /// Klasa koja predstavlja sadnicu.
    /// </summary>
    public class Sadnica
    {
        /// <summary>
        /// Jedinstveni identifikator sadnice.
        /// </summary>
        [Key]
        public int ID_Sadnice { get; set; }

        /// <summary>
        /// Vrsta sadnice.
        /// </summary>
        [Required]
        [StringLength(50)]
        public string Vrsta { get; set; }

        /// <summary>
        /// Visina sadnice u metrima.
        /// </summary>
        [Required]
        [Range(0.01, 999.99)]
        public decimal Visina { get; set; }

        /// <summary>
        /// Starost sadnice u godinama.
        /// </summary>
        [Required]
        [Range(0, 100)]
        public int Starost { get; set; }

        /// <summary>
        /// Datum sadnje sadnice.
        /// </summary>
        [Required]
        public DateTime Datum_sadnje { get; set; }

        /// <summary>
        /// Jedinstveni identifikator rasadnika kojem pripada sadnica.
        /// </summary>
        [Required]
        public int ID_Rasadnika { get; set; }

        /// <summary>
        /// Referenca na rasadnik kojem sadnica pripada.
        /// </summary>
        public Rasadnik Rasadnik { get; set; }
    }
}
