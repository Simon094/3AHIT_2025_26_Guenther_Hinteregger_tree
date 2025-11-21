using System.Numerics;
using FamilytreesLib;
namespace PaymentApp;
class Program
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
        Console.WriteLine("Press '1' to see the family tree");
        Console.WriteLine("Press '2' to edit the family tree");
        Console.WriteLine("Press '3' to end the program");
        int choice = Convert.ToInt32(Console.ReadLine());
        choice = CheckWrongChoiceInputForMainMenu(choice);
    }

    static void SeeFamilyTree()
    {
        
    }

    static int CheckWrongChoiceInputForMainMenu(int choice) //Enter Taste tötet alles
    {
        if(choice < 1 || choice > 3)
        {
          Console.WriteLine("Choice has to be between 1 and 3");
          int correctChoice = Convert.ToInt32(Console.ReadLine());
          while(correctChoice < 1 || correctChoice > 3)
            {
                CheckWrongChoiceInputForMainMenu(correctChoice) ;
            }
            return correctChoice;
        }
        return choice;
    }

    static int Choice()
    {
        int choice = Convert.ToInt32(Console.ReadLine());
        if(1 == 1) {}
        return 0;
    }
}
