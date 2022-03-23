using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicee.Response.Cartadicredito
{
    public class CartadicreditoResponse
    {
        public int? Id { get; set; }
        public int? Numerocarta { get; set; }
        public DateTime? Scadenza { get; set; }
        public int? Validita { get; set; }
        public int? Personaid { get; set; }

    }
}
