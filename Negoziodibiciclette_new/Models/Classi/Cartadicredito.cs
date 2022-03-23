using System;
using System.Collections.Generic;

#nullable disable

namespace Models.Classi
{
    public partial class Cartadicredito
    {
        public int Id { get; set; }
        public int? Numerocarta { get; set; }
        public DateTime? Scadenza { get; set; }
        public int? Validita { get; set; }
        public int PersonaId { get; set; }
        public string Email { get; set; }

        public virtual Persona Persona { get; set; }
    }
}
