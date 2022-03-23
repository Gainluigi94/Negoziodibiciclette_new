using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicee.Request.Cartadicredito
{
   public class CartadicreditoRequest
    {


        public int? Id { get; set; }
        public int? Numerocarta { get; set; }
        public DateTime? Scadenza { get; set; }
        public int? Validita { get; set; }

        public int? Personaid { get; set; }

        public string Email { get; set; }

    }
}
