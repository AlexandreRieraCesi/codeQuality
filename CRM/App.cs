using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CRM.Client;
using static CRM.Prospect;

namespace CRM
{
    internal class App
    {
        static void Main(string[] args)
        {
            // Display the number of command line arguments.
            Console.WriteLine("Le nombre de clients est de : " + CRM.Client.CountClients());

            // Display the number of command line arguments.
            Console.WriteLine("Le nombre de Prospects est de : " + CRM.Prospect.CountProspects());
        }
    }
}
