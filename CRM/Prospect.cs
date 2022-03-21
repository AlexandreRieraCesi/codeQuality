using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    internal class Prospect : User
    {
        public Prospect(DateTime? dateDeContrat)
        {
            DateDeContrat = dateDeContrat;
        }

        public DateTime? DateDeContrat { get; set; }

    }
}
