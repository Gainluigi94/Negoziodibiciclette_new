using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicee.Response.Bici
{
  public  class GetAllBici
    {



        public int? Id { get; set; }
        public string? Nome { get; set; }
        public string? Modello { get; set; }
        public int? Ruote { get; set; }
        public int? Prezzo { get; set; }
    }
}
