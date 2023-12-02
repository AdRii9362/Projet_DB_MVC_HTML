namespace MaMVC.mvc.Models._21_DAL._211_Entities
{
    // Dans cette class, nous déclarons nos champs de notre DB en C#
    // respecter la convertions des types SQL en C#

        #nullable disable //permet de desactiver le nullable de nos entités
    public class MaTable
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int Annee { get; set; }

    }
}
