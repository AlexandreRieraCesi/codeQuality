using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    internal class Facture
    {
        public Facture(int id, int idClient, int idOffre, double offreMontant, DateTime dateEmission, DateTime datePaiement, bool isPaid)
        {
            Id = id;
            IdClient = idClient;
            IdOffre = idOffre;
            OffreMontant = offreMontant;
            DateEmission = dateEmission;
            DatePaiement = datePaiement;
            IsPaid = isPaid;
        }

        public int Id { get; set; }
        public int IdClient { get; }
        private int IdOffre { get; }
        public double OffreMontant { get; set; }
        public DateTime DateEmission { get; set; }
        public DateTime DatePaiement { get; set; }
        public bool IsPaid { get; set; }

       

    }
}
