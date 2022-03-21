using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    internal class Offre
    {
        public Offre(string nom, float montant, DateTime dateDeValidite)
        {
            Nom = nom;
            Montant = montant;
            DateDeValidite = dateDeValidite;
        }

        public string Nom { get; set; }
        public float Montant { get; set; }
        public DateTime DateDeValidite { get; set; }
    }
}
