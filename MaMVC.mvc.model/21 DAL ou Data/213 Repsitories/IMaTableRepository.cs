using MaMVC.mvc.Models._21_DAL._211_Entities; 

namespace MaMVC.mvc.Models._21_DAL._213_Repsitories
{
    /*
     Les repositories sont déclarés sous forme d'interfaces 
    (définit par un contrat dont le type qui implémente l'interface 
    doit implémenter les fonctionnalités) qui vont contenir les différentes 
    actions à réaliser sur une entité. 
    */

    // Déclaration de l'interface IMaTableRepository
    public interface IMaTableRepository
    {
        // Signature de la méthode Insert
        // Cette méthode sera implémentée par les classes qui utilisent cette interface

        //test avec id
        //public MaTable Insert(MaTable maTable); // Méthode Insert maTable
        public bool Insert(MaTable maTable);
    }
}


// Insérer la nouvelle entrée dans la base de données en utilisant les données fournies dans maTable.
// L'implémentation spécifique de cette opération d'insertion dépend du code à l'intérieur de cette méthode.
// Cela pourrait impliquer l'utilisation de requêtes SQL, de méthodes d'un ORM (Object-Relational Mapping), etc.
// Corps de la méthode
// Instructions à exécuter lorsque la méthode est appelée