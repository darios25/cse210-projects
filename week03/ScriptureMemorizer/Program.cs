// Author: Dario Giaccone
// This program meets all the basic requirements and has features beyond the basic requirements:
// - Handles verse ranges
// - Hides only visible words
// - Displays scriptures with hidden words as underscores
// - Clears the console after each cycle

using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string verse = "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.";

        Scripture scripture = new Scripture(reference, verse);

        while (!scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            scripture.HideRandomWords();

        }

        Console.Clear();
        Console.WriteLine("Memorization complete!");
        Console.WriteLine(scripture.GetDisplayText());

    }
}


