using MaMVC.mvc.Models._21_DAL._211_Entities;
using MaMVC.mvc.Models._21_DAL._213_Repsitories;
using System.Data.SqlClient;

namespace MaMVC.mvc.Models._21_DAL._214_Services
{
    public class MaTableService : IMaTableRepository//On implémente notre interface pour respecter le contrat du repository
    {
        //public MaTable Insert (MaTable maTable)
            public bool Insert(MaTable maTable)
        {
            //Logique de connexion à la source de données json, object, database,etc..

            using (SqlConnection connection = new SqlConnection())
            {
                connection.ConnectionString = @"Data Source=GOS-VDI206\TFTIC;Initial Catalog=MaDB;Integrated Security=True;Connect Timeout=60;";
            
                using (SqlCommand command = connection.CreateCommand()) 
                {
                    //je déclare mes paramètres
                    //command.CommandText = "INSERT INTO MaTable (Nom, Prenom, Annee) OUTPUT inserted.Id VALUES (@Nom,@Prenom,@Annee)";
                    command.CommandText = "INSERT INTO MaTable (Nom, Prenom, Annee) VALUES (@Nom,@Prenom,@Annee)";
                    command.Parameters.AddWithValue("Nom", maTable.Nom);
                    command.Parameters.AddWithValue("Prenom", maTable.Prenom);
                    command.Parameters.AddWithValue("Annee", maTable.Annee);

                    connection.Open();

                    //je dois exécuter
                    try
                    {
                        command.ExecuteNonQuery();
                        Console.WriteLine("Ajout OK");
                        return true;
                    }
                    catch (Exception )
                    {
                        Console.WriteLine("erreur d ajout");
                        return false;
                    }
                    //maTable.Id = (int)command.ExecuteScalar();
                   

                    //return maTable;
                }


            }
        }
    }
}
