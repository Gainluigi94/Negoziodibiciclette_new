using System;
using System.Collections.Generic;

#nullable disable

namespace Models.Classi
{
    public partial class Acquisti
    {
        public int? Id { get; set; }
        public int BiciId { get; set; }
        public int PersonaId { get; set; }
        public string Email { get; set; }

        public virtual Bici Bici { get; set; }
        public virtual Persona Persona { get; set; }
    }
}
