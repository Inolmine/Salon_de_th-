using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using salon_de_thee.Models;

namespace salon_de_thee.dal
{
    internal class DbBoissons
    {
        private Dbconx cnx;
        
        public DbBoissons(Dbconx cnx)
        {
            this.cnx = cnx;

        }

        public void AjouterBoisson(Boissons boisson)
        {
            try
            {

                string query = "INSERT INTO boisson (idboisson,designation,prix,qtestock) VALUES (@id,@designation,@prix,@qtestock)";
                SqlCommand command = new SqlCommand(query, cnx.Db);

                command.Parameters.AddWithValue("@id", boisson.IdBoisson);
                command.Parameters.AddWithValue("@designation",boisson.Designation );
                command.Parameters.AddWithValue("@prix",boisson.Prix);
                command.Parameters.AddWithValue("@qtestock",boisson.QteStock);


                command.ExecuteNonQueryAsync();
                MessageBox.Show("Ajouter Boisson");




            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de l'ajout du serveur:");
                Console.WriteLine(ex.Message);
            }
        }
        public void SupprimerBoisson(int id)
        {
            try
            {

                string query = "Delete from boisson Where id = @id";
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

        public void ModifierBoisson(int id, string designation, double prix,int qtestock)
        {
            try
            {

                string query = "Update Boisson SET designation = @designation, prix = @prix, qtestock = @qtestock where idboisson=@id  ";
                SqlCommand command = new SqlCommand(query, cnx.Db);

                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@designation", designation);
                command.Parameters.AddWithValue("@prix", prix);
                command.Parameters.AddWithValue("@qtestock", qtestock);
                command.ExecuteNonQueryAsync();
                MessageBox.Show("modifier");




            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors de l'ajout du serveur:");
                Console.WriteLine(ex.Message);
            }
        }
        public Boissons ChercherBoisson(int id)
        {
            Boissons boissons = null;
            string query = "SELECT * FROM Boisson WHERE IdBoisson = @Id";
            SqlCommand command = new SqlCommand(query, cnx.Db);
            command.Parameters.AddWithValue("@Id", id);
            try
            {

                SqlDataReader rs = command.ExecuteReader();
                if (rs.Read())
                {
                    boissons = new Boissons
                    {
                        IdBoisson = (int)rs["Idboisson"],
                        Designation = (String)rs["designation"],
                        Prix = (double)rs["prix"],
                        QteStock = (int)rs["qtestock"]
                    };
                }
                rs.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message);

            }
            return boissons;


        }
    }
}
