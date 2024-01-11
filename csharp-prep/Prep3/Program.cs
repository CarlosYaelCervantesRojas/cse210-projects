using System;

class Program
{
    static void Main(string[] args)
    {
        int magicNumber, guess;
        int guesses = 0;
        string play = "yes";

        while (play == "yes")
        {
            Random ramdomGenerator = new Random();
            magicNumber = ramdomGenerator.Next(1, 100);
        
        do
        {
            Console.Write("What is your guess? ");
            string askGuess = Console.ReadLine();
            guess = int.Parse(askGuess);

            string higherLower = "";
            if (guess > magicNumber)
            {
                higherLower = "Lower";
            }
            else if (guess < magicNumber)
            {
                higherLower = "Higher";
            }
            else
            {
                higherLower = "You guessed it!";
            }

            guesses ++;
            Console.WriteLine(higherLower);
            
        } while (guess != magicNumber);

        Console.WriteLine($"You tried {guesses} times to guess.");
        guesses = 0;

        Console.Write("Would you like to play again?(yes/no) ");
        play = Console.ReadLine();

        }
    }
}