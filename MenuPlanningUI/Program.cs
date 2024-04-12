using MenuPlanningBL;
using MenuPlanningDL;
using MenuPlanning;
namespace MenuPlanningUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\nMenu Plan for a Day");
                Console.WriteLine("1. Information about the program");
                Console.WriteLine("2. Proceed to Program");
                Console.WriteLine("3. Exit");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine("This program will let you pick which meal option you want and will show the recommended dishes, beverages, preference, nutritional value and time when you will eat");
                        break;

                    case "2":

                        Data.SelectDay();

                        break;

                    case "3":
                        exit = true;
                        break;

                    default:
                        Console.WriteLine("Wrong Input. Please Try Again");
                        break;
                }

            }
        }
    }
}
