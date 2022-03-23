using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicee.Request.Indirizzo
{
   public class EditIndirizzo
    {

        public int? Id { get; set; }
        public string Via { get; set; }
        public int? Cap { get; set; }
        public string Comune { get; set; }
        public string Trav { get; set; }
        public int? Numerocivico { get; set; }
    }
}
