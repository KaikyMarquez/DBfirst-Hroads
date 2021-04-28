using System;
using System.Collections.Generic;

#nullable disable

namespace senai.hroads.webApi.Domains
{
    public partial class Classes
    {
        public Classes()
        {
            Intermediaria = new HashSet<Intermediaria>();
            Personagens = new HashSet<Personagens>();
        }

        public int IdClasse { get; set; }
        public string Classe { get; set; }

        public virtual ICollection<Intermediaria> Intermediaria { get; set; }
        public virtual ICollection<Personagens> Personagens { get; set; }
    }
}
