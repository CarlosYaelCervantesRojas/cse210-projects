using System;

class Program
{
    static void Main(string[] args)
    {
        int numberToSquare;
        double square;
        string name;


        DisplayWelcome();
        name = PromptUserName();
        numberToSquare = PromptUserNumber();
        square = SquareNumber(numberToSquare);
        DisplayResult(name, square);


        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("Please enter your name: ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        static double SquareNumber(int number)
        {
            double numberToSquare = Math.Pow(number, 2);
            return numberToSquare;
        }

        static void DisplayResult(string name, double number)
        {
            Console.WriteLine($"{name}, the square of your number is {number}");
        }
    }
}