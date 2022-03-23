using System;
using System.Collections.Generic;

#nullable disable

namespace Models.Classi
{
    public partial class Persona
    {
        public Persona()
        {
            Acquistis = new HashSet<Acquisti>();
            Cartadicreditos = new HashSet<Cartadicredito>();
            Utentes = new HashSet<Utente>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Nascita { get; set; }
        public string Nazione { get; set; }
        public string Sesso { get; set; }
        public string Codicefiscale { get; set; }
        public string? Email { get; set; }
       
        public int? BiciId { get; set; }

        public virtual Bici Bici { get; set; }
        public virtual ICollection<Acquisti> Acquistis { get; set; }
        public virtual ICollection<Cartadicredito> Cartadicreditos { get; set; }
        public virtual ICollection<Utente> Utentes { get; set; }
    }
}
