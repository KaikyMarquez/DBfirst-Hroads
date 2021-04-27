using System;
using System.Collections.Generic;

#nullable disable

namespace senai.hroads.webApi.Domains
{
    public partial class Class
    {
        public Class()
        {
            Intermediaria = new HashSet<Intermediaria>();
            Personagens = new HashSet<Personagen>();
        }

        public int IdClasse { get; set; }
        public string Classe { get; set; }

        public virtual ICollection<Intermediaria> Intermediaria { get; set; }
        public virtual ICollection<Personagen> Personagens { get; set; }
    }
}
