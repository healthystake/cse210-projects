using System.Collections.Generic;
using System.IO;

namespace JournalApp
{
    // Manages a collection of journal entries
    public class Journal
    {
        // List of journal entries
        public List<Entry> Entries { get; set; } = new List<Entry>();

        // Instance of the prompt generator
        private PromptGenerator _promptGenerator = new PromptGenerator();

        // Adds a new entry to the journal
        public void AddEntry()
        {
            // Get a random prompt and display it
            string prompt = _promptGenerator.GetRandomPrompt();
            Console.WriteLine(prompt);

            // Read user's response
            string response = Console.ReadLine();

            // Create a new entry and add it to the list
            Entries.Add(new Entry { Prompt = prompt, Response = response, Date = DateTime.Now.ToString("yyyy-MM-dd") });
        }

        // Displays all entries in the journal
        public void Display()
        {
            foreach (var entry in Entries)
            {
                entry.Display();
            }
        }

        // Saves the journal to a file
        public void Save(string filename)
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (var entry in Entries)
                {
                    writer.WriteLine($"{entry.Date}~|~{entry.Prompt}~|~{entry.Response}");
                }
            }
        }

        // Loads the journal from a file
        public void Load(string filename)
        {
            if (File.Exists(filename))
            {
                Entries.Clear();
                using (StreamReader reader = new StreamReader(filename))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(new string[] { "~|~" }, StringSplitOptions.None);
                        if (parts.Length == 3)
                        {
                            Entries.Add(new Entry { Date = parts[0], Prompt = parts[1], Response = parts[2] });
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("File not found.");
            }
        }
    }
}
