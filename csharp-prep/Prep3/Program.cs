using System;

class Program
{
    static void Main(string[] args)
    {  
        // Generate a random number between 1 and 100 
        Random random = new Random(); int magicNumber = random.Next(1, 101);
        int guess = 0; 
            
            Console.WriteLine("I have chosen a number between 1 and 100.Try to guess it!");
            
            // Keep looping until the guess matches the magic number
            while (guess != magicNumber) 
            { 
                // Ask the user for a guess 
                Console.Write("What is your guess? "); 
            guess = int.Parse(Console.ReadLine()); 
            // Determine if the guess is higher, lower, or correct 
            if (guess < magicNumber) 
            { 
                Console.WriteLine("Higher"); 
            }
             else if (guess > magicNumber) 
            { 
                Console.WriteLine("Lower"); 
            } 
             else 
            { 
                Console.WriteLine("You guessed it!"); 
            } 
             
        }  
    }
}
