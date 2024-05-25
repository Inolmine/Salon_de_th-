using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salon_de_thee.Models
{
    internal class BoissonCommande
    {
        private int idboisson;
        private int idcommande;
        private int qtecommande;

        public BoissonCommande() 
        {

        }    
        public BoissonCommande(int idboisson, int idcommande, int qtecommande)
        {
            this.Idboisson = idboisson;
            this.Idcommande = idcommande;
            this.Qtecommande = qtecommande;
        }

        public int Idboisson { get => idboisson; set => idboisson = value; }
        public int Idcommande { get => idcommande; set => idcommande = value; }
        public int Qtecommande { get => qtecommande; set => qtecommande = value; }
    }
}
