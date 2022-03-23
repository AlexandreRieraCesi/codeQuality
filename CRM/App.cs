using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CRM.Services.Client_controller;
using static CRM.Services.Facture_controller;
using static CRM.Services.Prospect_controller;

namespace CRM
{
    static internal class App
    {
        static void Main(string[] args)
        {
            // Display the number of command line arguments.
            Console.WriteLine("Le nombre de clients est de : " + CountClients());
            Console.WriteLine("");
            // Display the number of command line arguments.
            Console.WriteLine("Le nombre de Prospects est de : " + CountProspects());
            Console.WriteLine("");
            Console.WriteLine("");
            isPaidFactureOneByOne();
            Console.WriteLine("");
            Console.WriteLine("");

        }
    }
}
