using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CRM.Client;

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
        private int IdClient { get; }
        private int IdOffre { get; }
        public double OffreMontant { get; set; }
        public DateTime DateEmission { get; set; }
        public DateTime DatePaiement { get; set; }
        public bool IsPaid { get; set; }

        
        public static void isPaidFactureOneByOne()
        {
            Facture facture1 = new(1, 1, 1, 103.23, new DateTime(), new DateTime(), true);
            Facture facture2 = new(2, 2, 1, 59.90, new DateTime(), new DateTime(), true);
            Facture facture3 = new(3, 3, 1, 2490.59, new DateTime(), new DateTime(), false);

            List<Facture> facturesList = new() { facture1, facture2, facture3 };

            Console.WriteLine("LES FACTURES SONT ELLES PAYÉES ?");
            Console.WriteLine("");

            foreach (Facture facture in facturesList)
            {
                if (facture.IsPaid)
                {
                    Console.WriteLine("La Facture N°" + facture.Id + " emmise le " + facture.DateEmission + " d'un montant de " + facture.OffreMontant + " Euros a été payée !");
                }
                else
                {
                    Console.WriteLine("La Facture N°" + facture.Id + " emmise le " + facture.DateEmission + " d'un montant de " + facture.OffreMontant + " Euros n'est pas payée !!!");
                }
            }
        }

        public static void isPaidFactureByClient()
        {

            Facture facture1 = new(1, 1, 1, 103.23, new DateTime(), new DateTime(), true);
            Facture facture2 = new(2, 2, 1, 59.90, new DateTime(), new DateTime(), true);
            Facture facture3 = new(3, 3, 1, 2490.59, new DateTime(), new DateTime(), false);

            List<Facture> facturesList = new() { facture1, facture2, facture3 };
            List<Client> clients = GetClients();

            Console.WriteLine("EST-CE QUE LE CLIENT A PAYÉ SES FACTURES ?");
            Console.WriteLine("");

            foreach (Client client in clients)
            {
                foreach (Facture facture in facturesList)
                {
                    if (facture.IsPaid && facture.IdClient == client.Id)
                    {
                        Console.WriteLine("La Facture N°" + facture.Id + " emmise le " + facture.DateEmission + " d'un montant de " + facture.OffreMontant + " Euros a été payée !");
                    }
                    else
                    {
                        Console.WriteLine("La Facture N°" + facture.Id + " emmise le " + facture.DateEmission + " d'un montant de " + facture.OffreMontant + " Euros n'est pas payée !!!");
                    }
                }
            }
        }

    }
}
