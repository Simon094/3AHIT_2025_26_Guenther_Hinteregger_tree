using System.Numerics;
using FamilytreesLib;
namespace PaymentApp;
using Microsoft.Data.Sqlite;
class Program 
{
  static void Main(string[] args) //Mayr
  {
    StartProgram(); //Mayr
  }

  static void StartProgram() //Mayr
    {
        Console.WriteLine("Willkommen bei der Stammbaum-Software Familie Hinteregger");
        Console.WriteLine("-------------------------------------------------");
        Console.WriteLine("");
        Console.WriteLine("Was möchten sie tun?");
        HauptMenu();
    }

    static void HauptMenu() //Mayr
    {
        FamilyTree Hinteregger = new FamilyTree("Hinteregger");
        Console.WriteLine("-------------------------------------------------");
        Console.WriteLine("Drücke '1' um den Stammbaum zu sehen");
        Console.WriteLine("Drücke '2' um den Stammbaum zu bearbeiten");
        Console.WriteLine("Drücke '3' um den Stammbaum als PDF zu bekommen");
        Console.WriteLine("Drücke '4' um den Stammbaum zu verlassen");
        Console.WriteLine("Drücke '5' um den Stammbaum zu erstellen (falls noch nicht vorhanden)");
        int choicefirst = Convert.ToInt32(Console.ReadLine());
        int choicesecond = CheckWrongChoiceInputForMainMenu(choicefirst);
        if(choicesecond == 1)
        {
            SeeFamilyTree();
        } else if(choicesecond == 2)
        {
            EditFamilyTree();
        } else if(choicesecond == 3)
        {
            PrintFamilyTreeAsPdf();
        } else if(choicesecond == 4)
        {
            EndProgram();
        } else if(choicesecond == 5)
        {
            DatabaseCreator.CreateDatabase();
        }
    }

    static void SeeFamilyTree() //Mayr
    {
       
    }

    static void DisplayFamilyTreeInfos()
    {
        
    }

    static int CheckWrongChoiceInputForMainMenu(int choice) //Enter Taste tötet alles, Mayr
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

    static void EditFamilyTree() //Mayr
    {
        
    }

    static void PrintFamilyTreeAsPdf() //Mayr
    {
        
    }

    static void EndProgram()
    {
        //does nothing
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
            Console.WriteLine($"Vaterl Error: {sqlFilePath}");
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


   


