using System.Numerics;
using FamilytreesLib;
namespace PaymentApp;
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
        Console.WriteLine("Was möchten sie als erstes tun?");
        HauptMenu();
    }

    static void HauptMenu()
    {
        Console.WriteLine("-------------------------------------------------");
        Console.WriteLine("Drücke '1' um den Stammbaum zu sehen");
        Console.WriteLine("Drücke '2' um den Stammbaum zu bearbeiten");
        Console.WriteLine("Drücke '3' um den Stammbaum als PDF zu bekommen");
        Console.WriteLine("Drücke '4' um den Stammbaum zu verlassen");
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
        }
    }

    static void SeeFamilyTree()
    {
        
    }

    static int CheckWrongChoiceInputForMainMenu(int choice) //Enter Taste tötet alles
    {
        if(choice < 1 || choice > 4)
        {
          Console.WriteLine("Choice has to be between 1 and 4");
          int correctChoice = Convert.ToInt32(Console.ReadLine());
          while(correctChoice < 1 || correctChoice > 4)
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

}
