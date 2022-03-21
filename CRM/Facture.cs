using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    public class Facture
    {
        private int IdClient { get; }
        private int IdOffre { get; }
        public float OffreMontant { get; set; }
        public DateTime DateEmission { get; set; }
        public DateTime DatePaiement { get; set; }
        public bool IsPaid { get; set; }
    }
}
