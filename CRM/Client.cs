using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    internal class Client : User
    {
        public Client(string? raison_sociale, string? nom, string? prenom, string? numero_telephone, string? email, string? adresse) : base(raison_sociale, nom, prenom, numero_telephone, email, adresse)
        { }


        public int? NombreFactures { get; set; }
        public bool IsRecurrent { get; set; }

        public static int CountClients()
        {
            Client sommeUser1 = new Client("bla", "Olga", "Final", "0656847515", "fsfd@fs.fr", "54 rue de partout");
            Client sommeUser2 = new Client("bla", "Robert", "Amara", "0759623415", "dfgui@fs.fr", "22 rue de quelquepart");
            Client sommeUser3 = new Client("bla", "Jean", "Dupont", "0623985276", "ece@fs.fr", "10 rue of nowhere");

            List<Client> sommeUsersList = new() { sommeUser1, sommeUser2, sommeUser3 };

            int retour = sommeUsersList.Count();

            return retour;
        }
    }
}
