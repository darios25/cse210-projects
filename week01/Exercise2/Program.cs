using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your grade percentage: ");
        string input = Console.ReadLine();
        int percentage = int.Parse(input);

        string letterGrade = "";
        string sign = "";

        if (percentage >= 90)
        {
            letterGrade = "A";
        }
        else if (percentage >= 80)
        {
            letterGrade = "B";
        }
        else if (percentage >= 70)
        {
            letterGrade = "C";
        }
        else if (percentage >= 60)
        {
            letterGrade = "D";
        }
        else
        {
            letterGrade = "F";
        }

        // Determine the sign (only if not A+ or F+/-)
        int lastDigit = percentage % 10;

        if (letterGrade != "F")
        {
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit <= 3)
            {
                sign = "-";
            }
        }

        // no A+
        if (letterGrade == "A" && sign == "+")
        {
            sign = ""; // A+ does not exist
        }

        // no F+ or F-
        if (letterGrade == "F")
        {
            sign = ""; 
        }

        // Print the final grade
        Console.WriteLine($"Your grade is: {letterGrade}{sign}");

        // Check if the user passed
        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the exam.");
        }
        else
        {
            Console.WriteLine("Sorry, you did not pass. Keep trying, you'll do better next time!");
        }
    }
}