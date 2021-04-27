using System;
using System.Collections.Generic;

#nullable disable

namespace senai.hroads.webApi.Domains
{
    public partial class Personagen
    {
        public int IdPersonagem { get; set; }
        public int? IdClasse { get; set; }
        public string Nome { get; set; }
        public string CapacidadeMaximadeVida { get; set; }
        public string CapacidadeMaximadeMana { get; set; }
        public DateTime? DatadeAtualizacao { get; set; }
        public DateTime? DatadeCriacao { get; set; }

        public virtual Class IdClasseNavigation { get; set; }
    }
}
