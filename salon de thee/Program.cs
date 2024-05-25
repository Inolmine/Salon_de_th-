using salon_de_thee.dal;
using salon_de_thee.Models;
using salon_de_thee.View;
using salon_de_thee.View.Menu;

namespace salon_de_thee
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Dbconx dd = new Dbconx();
            Serveur s = new Serveur(1,"anas","anas");
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Dbserveur db = new Dbserveur(dd);
            DbBoissons db1 = new DbBoissons(dd);
            Dbcommande db2 = new Dbcommande(dd);
            Boissons b = new Boissons(1, "rabat", 123, 10);
            //db.AjouterServeurs(s);
            //db.SupprimerServeurs(1);
            //db.ModifierServeurs(1, "SSS", "FFFF");
            //db1.AjouterBoisson(b);
            Commande c = new Commande(8,DateTime.Now,2,1);
            //db.ChercherServeur(55);
            //db2.AjouterCommande(c);
            //db2.ModifierCommande(3, DateTime.Now, 55, 1);

           
            

            ApplicationConfiguration.Initialize();
            Application.Run(new Menu());

        }
    }
}