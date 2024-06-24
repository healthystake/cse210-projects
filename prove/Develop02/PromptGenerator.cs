using System;
using System.Collections.Generic;

namespace JournalApp
{
    // Responsible for generating random prompts for journal entries
    public class PromptGenerator
    {
        // List of predefined prompts
        private List<string> _prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };

        // Returns a random prompt from the list
        public string GetRandomPrompt()
        {
            Random random = new Random();
            return _prompts[random.Next(_prompts.Count)];
        }
    }
}
