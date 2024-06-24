using System;

namespace JournalApp
{
    // Represents a single journal entry
    public class Entry
    {
        // The prompt given for the entry
        public string Prompt { get; set; }

        // The user's response to the prompt
        public string Response { get; set; }

        // The date when the entry was made
        public string Date { get; set; }

        // Displays the entry in a formatted manner
        public void Display()
        {
            Console.WriteLine($"{Date} - {Prompt}");
            Console.WriteLine(Response);
            Console.WriteLine();
        }
    }
}
