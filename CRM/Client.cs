using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    public class Client : User
    {
        public int? NombreFactures { get; set; }
        public bool IsRecurrent { get; set; }
    }
}
