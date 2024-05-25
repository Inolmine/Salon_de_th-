using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace salon_de_thee.Models
{
    internal class Boissons
    {
        private int idBoisson;
        private string designation;
        private double prix;
        private int qteStock;

        public Boissons()
        {
            
        }
        public Boissons(int idBoisson, string designation, double prix, int qteStock)
        {
            this.IdBoisson = idBoisson;
            this.Designation = designation;
            this.Prix = prix;
            this.QteStock = qteStock;
        }

        public int IdBoisson { get => idBoisson; set => idBoisson = value; }
        public string Designation { get => designation; set => designation = value; }
        public double Prix{ get => prix; set => prix = value; }
        public int QteStock { get => qteStock; set => qteStock = value; }
    }
}
