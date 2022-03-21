using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    internal class User
    {
        public User(string? raison_sociale, string? nom, string? prenom, string? numero_telephone, string? email, string? adresse)
        {
            Raison_sociale = raison_sociale;
            Nom = nom;
            Prenom = prenom;
            Numero_telephone = numero_telephone;
            Email = email;
            Adresse = adresse;
        }

        public int Id { get; }
        public string? Raison_sociale { get; set; }
        public string? Nom { get; set; }
        public string? Prenom { get; set; }
        public string? Numero_telephone { get; set; }
        public string? Email { get; set; }
        public string? Adresse { get; set; }


    }
}
