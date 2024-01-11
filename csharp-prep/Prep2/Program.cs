using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Type your grade percentage: ");
        string percentage = Console.ReadLine();
        int grade = int.Parse(percentage);

        string letter = "";
        if (grade >= 90)
        {
            letter ="A";
        } 
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else if (grade < 60)
        {
            letter = "F";
        }

        int remainder = grade % 10;

        string sing = "";
        if (remainder >= 7 && !(letter == "A" || letter == "F"))
        {
            sing = "+";
        }
        else if (remainder < 3 && letter !="F" && grade != 100)
        {
            sing = "-";
        }

        Console.WriteLine($"{letter}{sing}");

        if (grade > 70)
        {
            Console.WriteLine("You passed the course.\nCongratulations!.");
        }
        else
        {
            Console.WriteLine("You fail the course.");
        }
    }
}