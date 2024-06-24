using System;
namespace JournalApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new journal instance
            Journal journal = new Journal();

            while (true)
            {
                // Display the menu options
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Write a new entry");
                Console.WriteLine("2. Display the journal");
                Console.WriteLine("3. Save the journal to a file");
                Console.WriteLine("4. Load the journal from a file");
                Console.WriteLine("5. Quit");
                Console.Write("Select an option: ");
                string option = Console.ReadLine();

                // Handle the menu selection
                switch (option)
                {
                    case "1":
                        journal.AddEntry();
                        break;
                    case "2":
                        journal.Display();
                        break;
                    case "3":
                        Console.Write("Enter filename to save: ");
                        string saveFilename = Console.ReadLine();
                        journal.Save(saveFilename);
                        break;
                    case "4":
                        Console.Write("Enter filename to load: ");
                        string loadFilename = Console.ReadLine();
                        journal.Load(loadFilename);
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please try again.");
                        break;
                }
            }
        }
    }
}

