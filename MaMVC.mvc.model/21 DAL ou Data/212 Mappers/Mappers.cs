using MaMVC.mvc.Models._21_DAL._211_Entities;
using System.Data.Common;

namespace MaMVC.mvc.Models._21_DAL._212_Mappers
{ //le Mapper transforme ce qui vient de ma base de données en un objet de type entité 
    internal static class Mappers
    {
        internal static MaTable ToMaTable(this DbDataReader reader) 
        {
            return new MaTable() //On retourne un nouvel objet 
            {
                /* variables de notre entité MaTable
                 
                    public int Id { get; set; }
                    public string Nom { get; set; }
                    public string Prenom { get; set; }
                    public int Annee { get; set; 

                 */
                
                Id = (int)reader["Id"],
                Nom = (string)reader["Nom"],
                Prenom = (string)reader["Prenom"],
                Annee = (int)reader["Annee"]
            };
        }
    }
}
