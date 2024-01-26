using System;

// Have the program to load scriptures from a file.
class Program
{
    static void Main(string[] args)
    {
        String file = "scriptures.txt";
        string[] lines = System.IO.File.ReadAllLines(file);
        
        Random rnd = new Random();
        string line = lines[rnd.Next(0, lines.Count())];
        string[] data = line.Split("|");

        string textScripture = data[0];
        string book = data[1];
        int chapter = int.Parse(data[2]);
        int verse = int.Parse(data[3]);
        int verseEnd;
        Reference reference;
        if (data.Count() == 5)
        {
            verseEnd = int.Parse(data[4]);
            reference = new Reference(book, chapter, verse, verseEnd);
        }
        else
        {
            reference = new Reference(book, chapter, verse);
        }

        Scripture scripture = new Scripture(reference, textScripture);

        string entry = "";
        int numberToHide = 0;
        while (entry != "quit")
        {
            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            entry = Console.ReadLine();

            if (scripture.IsCompletelyHidden())
            {
                return;
            }

            numberToHide += 3;
            scripture.HideRandomWords(numberToHide);
        }
    }
}