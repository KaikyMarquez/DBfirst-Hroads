using System;
using System.Collections.Generic;

#nullable disable

namespace senai.hroads.webApi.Domains
{
    public partial class Tipo
    {
        public int IdTipo { get; set; }
        public int? IdHabilidade { get; set; }
        public string Tipo1 { get; set; }

        public virtual Habilidade IdHabilidadeNavigation { get; set; }
    }
}
