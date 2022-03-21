using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    internal class Facture
    {
        public Facture(int idClient, int idOffre, float offreMontant, DateTime dateEmission, DateTime datePaiement, bool isPaid)
        {
            IdClient = idClient;
            IdOffre = idOffre;
            OffreMontant = offreMontant;
            DateEmission = dateEmission;
            DatePaiement = datePaiement;
            IsPaid = isPaid;
        }

        private int IdClient { get; }
        private int IdOffre { get; }
        public float OffreMontant { get; set; }
        public DateTime DateEmission { get; set; }
        public DateTime DatePaiement { get; set; }
        public bool IsPaid { get; set; }
    }
}
