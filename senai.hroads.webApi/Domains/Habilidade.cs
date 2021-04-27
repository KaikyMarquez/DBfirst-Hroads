using System;
using System.Collections.Generic;

#nullable disable

namespace senai.hroads.webApi.Domains
{
    public partial class Habilidade
    {
        public Habilidade()
        {
            Intermediaria = new HashSet<Intermediaria>();
            Tipos = new HashSet<Tipo>();
        }

        public int IdHabilidade { get; set; }
        public string Habilidade1 { get; set; }

        public virtual ICollection<Intermediaria> Intermediaria { get; set; }
        public virtual ICollection<Tipo> Tipos { get; set; }
    }
}
