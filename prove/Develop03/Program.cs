using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Create a scripture reference and scripture text
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        Scripture scripture = new Scripture(reference, "Trust in the LORD with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.");

        // Display the complete scripture initially
        scripture.Display();
    
        // Start the user interaction loop
        while (true)
        {
            Console.WriteLine("Press Enter to continue or type 'quit' to exit.");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                // Exit the program if the user types 'quit'
                break;
            }

            // Hide random words in the scripture and display it again
            if (!scripture.HideRandomWords())
            {
                // If all words are hidden, notify the user and exit the loop
                Console.WriteLine("All words are hidden.");
                break;
            }

            // Display the scripture with hidden words
            scripture.Display();
        }
    }
}