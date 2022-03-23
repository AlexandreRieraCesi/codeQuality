using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    internal class Client : User
    {
        public Client(int id, string? raison_sociale, string? nom, string? prenom, string? numero_telephone, string? email, string? adresse) : base(id, raison_sociale, nom, prenom, numero_telephone, email, adresse)
        { }

        public int? NombreFactures { get; set; }
        public bool IsRecurrent { get; set; }
    }
}
