using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salon_de_thee.Models
{
    internal class Commande
    {
        private int idCommande;
        private DateTime dateCom;
        private int heure;
        private int serveur;

        public Commande()
        {

        }

        public Commande(int idCommande, DateTime dateCom, int heure, int serveur)
        {
            this.IdCommande = idCommande;
            this.DateCom = dateCom;
            this.Heure = heure;
            this.Serveur = serveur;
        }

        public int IdCommande { get => idCommande; set => idCommande = value; }
        public DateTime DateCom { get => dateCom; set => dateCom = value; }
        public int Heure { get => heure; set => heure = value; }
        internal int Serveur { get => serveur; set => serveur = value; }
    }
}
