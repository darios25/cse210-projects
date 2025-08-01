using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment baseAssignment = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(baseAssignment.GetSummary());

        // Test della classe MathAssignment
        MathAssignment math = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeworkList());

        // Test della classe WritingAssignment
        WritingAssignment writing = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(writing.GetSummary());
        Console.WriteLine(writing.GetWritingInformation());
    }


}