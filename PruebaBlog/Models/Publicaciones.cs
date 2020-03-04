using System;
using System.Collections.Generic;

namespace PruebaBlog.Models
{
    public partial class Publicaciones
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public DateTime? FechaPublicacion { get; set; }
    }
}
