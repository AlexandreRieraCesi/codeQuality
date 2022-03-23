using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CRM.Prospect;

namespace CRM.Services
{
    internal class Prospect_controller
    {
        public static int CountProspects()
        {
            Client prospect1 = new Client(1, "bla", "Olga", "Final", "0656847515", "fsfd@fs.fr", "54 rue de partout");
            Client prospect2 = new Client(2, "bla", "Robert", "Amara", "0759623415", "dfgui@fs.fr", "22 rue de quelquepart");
            Client prospect3 = new Client(3, "bla", "Jean", "Dupont", "0623985276", "ece@fs.fr", "10 rue of nowhere");

            List<Client> sommeProspectsList = new() { prospect1, prospect2, prospect3 };

            int retour = sommeProspectsList.Count;

            return retour;
        }
    }
}
