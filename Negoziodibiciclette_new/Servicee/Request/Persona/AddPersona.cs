using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicee.Request.Persona
{
  public  class AddPersona
    {


        public int? Id { get; set; }
        public string? Nome { get; set; }
        public string Cognome { get; set; }
        public string Nascita { get; set; }
        public string Nazione { get; set; }
        public string Sesso { get; set; }
        public string Codicefiscale { get; set; }
        public string? Email { get; set; }
        public int OrderNumber { get; set; }
        public int? BiciId { get; set; }


    }
}
