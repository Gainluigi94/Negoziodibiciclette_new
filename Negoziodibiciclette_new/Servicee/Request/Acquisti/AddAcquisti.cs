using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicee.Request.Acquisti
{
    public class AddAcquisti
    {
        public int? Id { get; set; }
        public int? BiciId { get; set; }
        public int? PersonaId { get; set; }
        public string? Email { get; set; }

    }

}
