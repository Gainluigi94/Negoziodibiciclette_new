using System;
using System.Collections.Generic;

#nullable disable

namespace Models.Classi
{
    public partial class Indirizzo
    {
        public int Id { get; set; }
        public string Via { get; set; }
        public int? Cap { get; set; }
        public string Comune { get; set; }
        public string Trav { get; set; }
        public int? Numerocivico { get; set; }
    }
}
