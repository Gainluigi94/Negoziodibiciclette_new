using System;
using System.Collections.Generic;

#nullable disable

namespace Models.Classi
{
    public partial class Utente
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public int? Username { get; set; }
        public string Passwordd { get; set; }

        public virtual Persona Persona { get; set; }
    }
}
