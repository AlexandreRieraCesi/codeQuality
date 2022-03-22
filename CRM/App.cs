using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CRM.Client;
using static CRM.Prospect;
using static CRM.Facture;

namespace CRM
{
    internal class App
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
