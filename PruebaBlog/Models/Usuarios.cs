using System;
using System.Collections.Generic;

namespace PruebaBlog.Models
{
    public partial class Usuarios
    {
        public int? Id { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime? FechaNacimiento { get; set; }
    }
}
