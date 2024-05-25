using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace salon_de_thee.Models
{
    internal class Serveur
    {
        private int idServeur;
        private string name;
        private string prenom;

        public Serveur()
        {

        }

        public Serveur(int idServeur, string name, string prenom)
        {
            this.IdServeur = idServeur;
            this.Name = name;
            this.Prenom = prenom;
        }

        public int IdServeur { get => idServeur; set => idServeur = value; }
        public string Name { get => name; set => name = value; }
        public string Prenom { get => prenom; set => prenom = value; }
    }
}
