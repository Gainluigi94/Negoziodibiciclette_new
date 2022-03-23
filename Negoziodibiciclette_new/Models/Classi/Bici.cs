using System;
using System.Collections.Generic;

#nullable disable

namespace Models.Classi
{
    public partial class Bici
    {
        public Bici()
        {
            Acquistis = new HashSet<Acquisti>();
            Personas = new HashSet<Persona>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Modello { get; set; }
        public int? Ruote { get; set; }
        public int? Prezzo { get; set; }

        public virtual ICollection<Acquisti> Acquistis { get; set; }
        public virtual ICollection<Persona> Personas { get; set; }
    }
}
