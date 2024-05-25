using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using salon_de_thee.Models;

namespace salon_de_thee.dal
{
    internal class Dbserveur
    {
        private Dbconx cnx;
        public Dbserveur(Dbconx cnx)
        { 
            this.cnx= cnx;
        }  

        public void AjouterServeurs(Serveur serveur)
        {
            try
            {

                string query = "INSERT INTO Serveur (nom,prenom,id) VALUES (@Nom, @Prenom,@id)";
                SqlCommand command = new SqlCommand(query,cnx.Db);

                command.Parameters.AddWithValue("@Nom", serveur.Name);
                command.Parameters.AddWithValue("@Prenom", serveur.Prenom);
                command.Parameters.AddWithValue("@id", serveur.IdServeur);
                
                
                command.ExecuteNonQueryAsync();
                //MessageBox.Show("Ajoutee");
            



            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de l'ajout du serveur:");
                Console.WriteLine(ex.Message);
            }

        }
        public void SupprimerServeurs(int id)
        {
            try
            {

                string query = "Delete from Serveur Where id = @id";
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

        public void ModifierServeurs(int id,string nom,string prenom)
        {
            try
            {

                string query = "Update Serveur SET nom = @nom , prenom = @prenom where id=@id  ";
                SqlCommand command = new SqlCommand(query, cnx.Db);

                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@nom",nom);
                command.Parameters.AddWithValue("@prenom", prenom);
                command.ExecuteNonQueryAsync();
                MessageBox.Show("Ajoutee");




            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de l'ajout du serveur:");
                Console.WriteLine(ex.Message);
            }
        }

       /* public void ChercherServeur(int id)
        {
            try
            {

                string query = "select * from Serveur Where id = @id";
                SqlCommand command = new SqlCommand(query, cnx.Db);

                command.Parameters.AddWithValue("@id", id);



                command.ExecuteNonQueryAsync();
                MessageBox.Show("existe");




            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de l'ajout du serveur:");
                Console.WriteLine(ex.Message);
            }

        }*/
        public Serveur ChercherServeur(int id)
        {
            Serveur serveur = null;
            string query = "SELECT * FROM Serveur WHERE Id = @Id";
            SqlCommand command = new SqlCommand(query, cnx.Db);
            command.Parameters.AddWithValue("@Id", id);
            try
            {
                
                SqlDataReader rs = command.ExecuteReader();
                if (rs.Read())
                {
                    serveur  = new Serveur
                    {
                        IdServeur = (int)rs["Id"],
                        Name = (String)rs["Nom"],
                        Prenom = (String)rs["Prenom"]
                    };
                }
                rs.Close();
                


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);
                
            }
            return serveur;


        }
    }
  
}
