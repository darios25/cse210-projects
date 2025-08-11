using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static List<Goal> goals = new List<Goal>();
    static int totalPoints = 0;

    static void Main(string[] args)
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("\n--- Eternal Quest ---");
            Console.WriteLine("1. View Goals");
            Console.WriteLine("2. Add New Goal");
            Console.WriteLine("3. Log Event");
            Console.WriteLine("4. View Score");
            Console.WriteLine("5. Save");
            Console.WriteLine("6. Load");
            Console.WriteLine("7. Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    foreach (Goal g in goals)
                        Console.WriteLine(g.GetDetailsString());
                    break;
                case "2":
                    Goal newGoal = CreateNewGoal();
                    if (newGoal != null)
                    {
                        goals.Add(newGoal);
                        Console.WriteLine("Objective added!");
                    }
                    break;
                case "3":
                    RecordGoalEvent();
                    break;
                case "4":
                    Console.WriteLine($"Total score: {totalPoints}");
                    Console.WriteLine($"Current level: {GetLevel(totalPoints)}");
                    break;
                case "5":
                    SaveGoals();
                    break;
                case "6":
                    LoadGoals();
                    break;
                case "7":
                    running = false;
                    break;
            }
        }
    }

    static Goal CreateNewGoal()
    {
        Console.WriteLine("Choose the goal type:");
        Console.WriteLine("1. Simple goal");
        Console.WriteLine("2. Eternal goal");
        Console.WriteLine("3. Checklist goal");

        string choice = Console.ReadLine();

        Console.Write("Name: ");
        string name = Console.ReadLine();
        Console.Write("Description: ");
        string description = Console.ReadLine();
        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case "1":
                return new SimpleGoal(name, description, points);
            case "2":
                return new EternalGoal(name, description, points);
            case "3":
                Console.Write("How many times does it need to be completed? ");
                int target = int.Parse(Console.ReadLine());
                Console.Write("Final bonus: ");
                int bonus = int.Parse(Console.ReadLine());
                return new ChecklistGoal(name, description, points, target, bonus);
            default:
                Console.WriteLine("Invalid choice.");
                return null;
        }
    }

    static void RecordGoalEvent()
    {
        Console.WriteLine("What goal do you want to record?");
        for (int i = 0; i < goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {goals[i].GetName()}");
        }

        int index = int.Parse(Console.ReadLine()) - 1;
        if (index >= 0 && index < goals.Count)
        {
            int earned = goals[index].RecordEvent();
            totalPoints += earned;
            Console.WriteLine($"You've earned {earned} points!");
            Console.WriteLine("Event logged! Keep it up!");
        }
    }

    static int GetLevel(int points)
    {
        return (points / 1000) + 1;
    }

    static void SaveGoals()
    {
        using (StreamWriter writer = new StreamWriter("goals.txt"))
        {
            foreach (Goal g in goals)
            {
                writer.WriteLine(g.GetStringRepresentation());
            }
            writer.WriteLine($"Points:{totalPoints}");
        }
        Console.WriteLine("Saved Goals.");
    }

    static void LoadGoals()
    {
        if (File.Exists("goals.txt"))
        {
            string[] lines = File.ReadAllLines("goals.txt");
            goals.Clear();

            foreach (string line in lines)
            {
                if (line.StartsWith("Points:"))
                {
                    totalPoints = int.Parse(line.Split(':')[1]);
                }
                else
                {
                    goals.Add(GoalFactory.CreateGoalFromString(line));
                }
            }
            Console.WriteLine("Objectives loaded.");
        }
        else
        {
            Console.WriteLine("No files found.");
        }
    }
}



