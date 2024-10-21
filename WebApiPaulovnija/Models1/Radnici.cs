using System.Collections.Generic;
using WebApiPaulovnija.Models;

namespace WebApiPaulovnija.Controllers.Models
{
    /// <summary>
    /// Klasa koja predstavlja listu radnika.
    /// </summary>
    public class RadniciList
    {
        /// <summary>
        /// Lista radnika.
        /// </summary>
        public List<Radnik> ListaRadnika { get; set; } = new List<Radnik>();
    }
}
