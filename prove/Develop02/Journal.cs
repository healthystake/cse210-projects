using System;
using System.Collections.Generic;
using System.IO;

namespace JournalProgram
{
    // Class representing the journal which holds multiple entries
    public class Journal
    {
        private List<Entry> entries = new List<Entry>();
        private PromptGenerator promptGenerator = new PromptGenerator();

        public void WriteNewEntry()
        {
            string prompt = promptGenerator.GetRandomPrompt();
            Console.WriteLine(prompt);
            string response = Console.ReadLine();
            entries.Add(new Entry(prompt, response));
        }

        public void DisplayJournal()
        {
            foreach (var entry in entries)
            {
                Console.WriteLine(entry);
            }
        }

        public void SaveJournalToFile()
        {
            Console.Write("Enter filename to save journal: ");
            string filename = Console.ReadLine();
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (var entry in entries)
                {
                    writer.WriteLine($"{entry.Date}~|~{entry.Prompt}~|~{entry.Response}");
                }
            }
            Console.WriteLine("Journal saved successfully.");
        }

        public void LoadJournalFromFile()
        {
            Console.Write("Enter filename to load journal: ");
            string filename = Console.ReadLine();
            if (File.Exists(filename))
            {
                entries.Clear();
                using (StreamReader reader = new StreamReader(filename))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        var parts = line.Split(new[] { "~|~" }, StringSplitOptions.None);
                        if (parts.Length == 3)
                        {
                            entries.Add(new Entry(parts[1], parts[2]) { Date = parts[0] });
                        }
                    }
                }
                Console.WriteLine("Journal loaded successfully.");
            }
            else
            {
                Console.WriteLine("File not found.");
            }
        }
    }
}
