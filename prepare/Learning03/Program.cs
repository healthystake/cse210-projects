using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Create instances of Fraction using different constructors
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(6);
        Fraction fraction3 = new Fraction(3, 4);
        Fraction fraction4 = new Fraction(1, 3);

        // Display initial fractions using GetFractionString and GetDecimalValue
        Console.WriteLine($"Fraction 1: {fraction1.GetFractionString()} = {fraction1.GetDecimalValue()}");
        Console.WriteLine($"Fraction 2: {fraction2.GetFractionString()} = {fraction2.GetDecimalValue()}");
        Console.WriteLine($"Fraction 3: {fraction3.GetFractionString()} = {fraction3.GetDecimalValue()}");
        Console.WriteLine($"Fraction 4: {fraction4.GetFractionString()} = {fraction4.GetDecimalValue()}");

        // Change values using setters and display the updated fractions
        fraction1.SetTop(5);
        fraction1.SetBottom(8);
        Console.WriteLine($"Updated Fraction 1: {fraction1.GetFractionString()} = {fraction1.GetDecimalValue()}");

        fraction2.SetTop(7);
        fraction2.SetBottom(9);
        Console.WriteLine($"Updated Fraction 2: {fraction2.GetFractionString()} = {fraction2.GetDecimalValue()}");

        fraction3.SetTop(2);
        fraction3.SetBottom(5);
        Console.WriteLine($"Updated Fraction 3: {fraction3.GetFractionString()} = {fraction3.GetDecimalValue()}");

        fraction4.SetTop(4);
        fraction4.SetBottom(7);
        Console.WriteLine($"Updated Fraction 4: {fraction4.GetFractionString()} = {fraction4.GetDecimalValue()}");
    }
}

