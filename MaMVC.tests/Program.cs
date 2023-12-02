using MaMVC.mvc.Models._21_DAL._211_Entities;
using MaMVC.mvc.Models._21_DAL._213_Repsitories;
using MaMVC.mvc.Models._21_DAL._214_Services;

MaTable maTable = new MaTable()
{
    Nom = "VanDenBosch",
    Prenom = "Dylan",
    Annee = 1998
};

IMaTableRepository repository = new MaTableService();
repository.Insert(maTable);

Console.WriteLine();//
