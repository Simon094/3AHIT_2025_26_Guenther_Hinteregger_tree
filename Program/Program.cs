using System.Numerics;
using FamilytreesLib;
namespace PaymentApp;
using Microsoft.Data.Sqlite;
class Program //Alles vom Mayr
{
  static void Main(string[] args)
  {
    StartProgram();
  }

  static void StartProgram()
    {
        Console.WriteLine("Willkommen bei der Stammbaum-Software");
        Console.WriteLine("-------------------------------------------------");
        Console.WriteLine("");
        Console.WriteLine("Was möchten sie tun?");
        HauptMenu();
    }

    static void HauptMenu()
    {
        Console.WriteLine("-------------------------------------------------");
        Console.WriteLine("Drücke '1' um den Stammbaum zu sehen");
        Console.WriteLine("Drücke '2' um den Stammbaum zu bearbeiten");
        Console.WriteLine("Drücke '3' um den Stammbaum als PDF zu bekommen");
        Console.WriteLine("Drücke '4' um den Stammbaum zu verlassen");
        Console.WriteLine("Drücke '5' um den Stammbaum zu erstellen (falls noch nicht vorhanden)");
        int choice = Convert.ToInt32(Console.ReadLine());
        choice = CheckWrongChoiceInputForMainMenu(choice);
        if(choice == 1)
        {
            SeeFamilyTree();
        } else if(choice == 2)
        {
            EditFamilyTree();
        } else if(choice == 3)
        {
            PrintFamilyTreeAsPdf();
        } else if(choice == 4)
        {
            EndProgram();
        } else if(choice == 5)
        {
            DatabaseCreator.CreateDatabase();
        }
    }

    static void SeeFamilyTree()
    {
       
    }

    static int CheckWrongChoiceInputForMainMenu(int choice) //Enter Taste tötet alles
    {
        if(choice < 1 || choice > 5)
        {
          Console.WriteLine("Auswahl muss zwischen 1 und 5 sein");
          int correctChoice = Convert.ToInt32(Console.ReadLine());
          while(correctChoice < 1 || correctChoice > 5)
            {
                CheckWrongChoiceInputForMainMenu(correctChoice) ;
            }
            return correctChoice;
        }
        return choice;
    }

    static void EditFamilyTree()
    {
        
    }

    static void PrintFamilyTreeAsPdf()
    {
        
    }

    static void EndProgram()
    {
        
    }

}




public static class DatabaseCreator //Kumpitsch
{
    public static void CreateDatabase()
    {
        string connectionString = "Data Source=datenbank.db";
        string sqlFilePath = "sourceDatabank.sql";

        if (!File.Exists(sqlFilePath))
        {
            Console.WriteLine($"Vaterl Error 🖕: {sqlFilePath}");
            return;
        }

        string sql = File.ReadAllText(sqlFilePath);

        try
        {
            using var connection = new SqliteConnection(connectionString);
            connection.Open();

            using var command = connection.CreateCommand();
            command.CommandText = sql;
            command.ExecuteNonQuery();

            Console.WriteLine("Datenbank erfolgreich erstellt!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Fehler beim Erstellen der Datenbank:");
            Console.WriteLine(ex.Message);
        }
    }
}


