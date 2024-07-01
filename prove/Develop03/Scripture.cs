using System;
using System.Collections.Generic;

public class Scripture
{
    public Reference Reference { get; private set; }
    private List<Word> Words;

    public Scripture(Reference reference, string text)
    {
        Reference = reference;
        Words = new List<Word>();
        foreach (var word in text.Split(' '))
        {
            Words.Add(new Word(word));
        }
    }

    public bool HideRandomWords()
    {
        Random random = new Random();
        bool allHidden = true;

        foreach (var word in Words)
        {
            if (!word.IsHidden)
            {
                allHidden = false;
                break;
            }
        }

        if (allHidden)
        {
            return false;
        }

        int wordsToHide = Math.Max(1, Words.Count / 5);
        for (int i = 0; i < wordsToHide; i++)
        {
            int index = random.Next(Words.Count);
            Words[index].Hide();
        }

        return true;
    }

    public void Display()
    {
        Console.Clear();
        Console.WriteLine(Reference);
        foreach (var word in Words)
        {
            Console.Write(word + " ");
        }
        Console.WriteLine();
    }
}

