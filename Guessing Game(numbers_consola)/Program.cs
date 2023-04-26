//Guessing Game: Create a program that generates a random number and asks the user to guess it.
//The program provides clues (e.g., "too high" or "too low") until the user correctly guesses the number.
using System;

class Program
{
    static void QorR()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\n       To reset the game press ENTER.");
        Console.WriteLine("            To quit the game type Q!");
        Console.ResetColor();
        string input = Console.ReadLine().ToLower();
        if (string.IsNullOrEmpty(input))
        {
            Console.ReadKey();
        }
        else if(input == "q")
        {
            Console.WriteLine("Quitting...");
            Environment.Exit(0);
        }
        else
        {
            Console.WriteLine("Invalid input. Quitting...");
            Environment.Exit(0);
        }
    }
    static void Display()
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("           WELCOME TO THE GUESSING GAME");
        Console.ResetColor();
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("     Try to guess the number between 1 and 100.");
        Console.ResetColor();
    }
    static void Main(string[] args)
    {
        while (true)
        {
            Display();
            Random random = new Random();
            int targetNumber = random.Next(1, 101); // Generates a random number between 1 and 100, inclusive
            int guess;
            int attempts = 0;
            do
            {
                Console.Write("\nEnter your guess: ");
                
                if (int.TryParse(Console.ReadLine(), out guess))
                {
                    if (guess > 100)
                    {
                        Console.WriteLine("Please enter a number between 1 and 100!");
                        break;
                    }
                    if (guess < targetNumber)
                    {
                        Console.WriteLine("Too low!");
                        attempts++;
                    }
                    else if (guess > targetNumber)
                    {
                        Console.WriteLine("Too high!");
                        attempts++;
                    }
                    else
                    {
                        Console.WriteLine($"Congratulations! You guessed the number {targetNumber} in {attempts} attempts!");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            } while (guess != targetNumber);
                QorR();
        }
    }
}
