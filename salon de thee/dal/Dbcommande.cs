using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using salon_de_thee.Models;

namespace salon_de_thee.dal
{
    internal class Dbcommande
    {
        private Dbconx cnx;

        public Dbcommande(Dbconx cnx)
        {
            this.cnx = cnx;

        }

        public void AjouterCommande(Commande commande)
        {
            try
            {

                string query ="INSERT INTO commande (idcommande,datecom,heure,idserveur) VALUES (@id,@dateCom, @heureCom, @idServeur)";
                SqlCommand command = new SqlCommand(query,cnx.Db);

                command.Parameters.AddWithValue("@id", commande.IdCommande);
                command.Parameters.AddWithValue("@dateCom", commande.DateCom);
                command.Parameters.AddWithValue("@heureCom", commande.Heure);
                command.Parameters.AddWithValue("@idServeur", commande.Serveur);
                command.ExecuteNonQuery();



               
                
                MessageBox.Show("Ajoute commande");




            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'ajout du serveur:");
                MessageBox.Show(ex.Message);
                
            }
        }

        public void SupprimerCommande(int id)
        {
            try
            {

                string query = "Delete from commande Where idcommande = @id";
                SqlCommand command = new SqlCommand(query, cnx.Db);

                command.Parameters.AddWithValue("@id", id);



                command.ExecuteNonQueryAsync();
                MessageBox.Show("supprimer");




            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de l'ajout du serveur:");
                Console.WriteLine(ex.Message);
            }

        }

        public void ModifierCommande(int id, DateTime date, int heure, int serveur)
        {


                try
                {
                    string query = "UPDATE commande SET datecom = @date, heure = @heure, idserveur = @idserveur WHERE idcommande = @id";
                    SqlCommand command = new SqlCommand(query, cnx.Db);

                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@date", date);
                    command.Parameters.AddWithValue("@heure", heure);
                    command.Parameters.AddWithValue("@idserveur", serveur);

                    command.ExecuteNonQueryAsync();
                    //MessageBox.Show("modifier");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erreur lors de la modification de la commande:");
                    Console.WriteLine(ex.Message);
                }

            
         }
        public Commande ChercherCommande(int id)
        {
            Commande commande = null;
            string query = "SELECT * FROM commande WHERE idcommande = @id";
            SqlCommand command = new SqlCommand(query, cnx.Db);
            command.Parameters.AddWithValue("@Id", id);
            try
            {

                SqlDataReader rs = command.ExecuteReader();
                if (rs.Read())
                {
                    commande = new Commande
                    {
                        IdCommande = (int)rs["idcommande"],
                        Heure = (int)rs["heure"],
                        Serveur = (int)rs["idserveur"],
                        DateCom = (DateTime)rs["datecom"]
                        
                    };
                }
                rs.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);

            }
            return commande;

        }
    }

}
